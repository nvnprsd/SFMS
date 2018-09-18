using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using PdfSharp.Pdf;
using PdfSharp.Drawing;
using System.IO;
using ScreenToPDF;

namespace Demo
{
    public partial class Fee_Submit : Form
    {
        ScreenCapture capScreen = new ScreenCapture();
        string i = @"C:\root";
     
        public Fee_Submit()
        {
            InitializeComponent();
            timer1.Start();
            if (!Directory.Exists(i))
            {
                Directory.CreateDirectory(i);

            }
        }


        private void Check_Click(object sender, EventArgs e)
        {
            feeofmnth.Items.Clear();
            MessageBox.Show("Please Wait .." + Environment.NewLine + Environment.NewLine + "Getting data from online database It May Take Few Seconds");
            string k="use demo";
            if(Cdur.Text=="3 Month")
           {

               k = "SELECT t1.months3 FrOM mnthname  t1 WHERE  NOT EXISTS (SELECT t2.feeofmonth from feesubmit t2 WHERE Stdid=" + id.Text + " and t1.months3 = t2.feeofmonth )";
           }
            else if(Cdur.Text=="6 Month")
           {

               k = "SELECT t1.months6 FrOM mnthname  t1 WHERE  NOT EXISTS (SELECT t2.feeofmonth from feesubmit t2 WHERE Stdid=" + id.Text + " and t1.months6 = t2.feeofmonth )";
            
           }
            else if(Cdur.Text=="12 Month")
            {
                k = "SELECT t1.months FrOM mnthname  t1 WHERE  NOT EXISTS (SELECT t2.feeofmonth from feesubmit t2 WHERE Stdid=" + id.Text + " and t1.months = t2.feeofmonth )";
            }
            //try
            //{
                string d = "server=naveen-pc;database=demo;Integrated Security=SSPI";
                SqlConnection con = new SqlConnection(d);
                con.Open();
                string st = "select Candidatename,fathername,mothername,uidai,Addate,mobilenumber,ctype,cdur,candpic,candsign from stdreg where Stdid=" + id.Text + "";
                SqlCommand cmd = new SqlCommand(st, con);
                cmd.ExecuteNonQuery();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    name.Text = rd["Candidatename"].ToString();
                    Fname.Text = rd["fathername"].ToString();
                    Mname.Text = rd["mothername"].ToString();
                    Aadhar.Text = rd["uidai"].ToString();
                    Addate.Text = rd["Addate"].ToString();
                    Mnumber.Text = rd["mobilenumber"].ToString();
                    Ctype.Text = rd["ctype"].ToString();
                    Cdur.Text = rd["cdur"].ToString();
                   // candpic.ImageLocation = @"E:\Demosoft\candpic" + id.Text + ".jpg";                    candsign.ImageLocation = @"E:\HDemosoft\candsign" + id.Text + ".jpg";
                    byte[] img1 = ((byte[])rd["CandPic"]);
                    MemoryStream ms = new MemoryStream(img1);
                    candpic.Image = Image.FromStream(ms); 
                    byte[] img2 = ((byte[])rd["Candsign"]);
                    MemoryStream ms2 = new MemoryStream(img2);
                    candsign.Image = Image.FromStream(ms2);
                 
                 
                    
                }
                rd.Close();
                con.Close();
                con.Dispose();
                SqlConnection sq = new SqlConnection(d);
                sq.Open();
                SqlCommand cm = new SqlCommand(k, sq);
                SqlDataReader dr = cm.ExecuteReader();
                while (dr.Read())
                {

                    feeofmnth.Items.Add(dr[0]);
                }
                feeofmnth.Items.Add("Costum");
               
           // }
            //catch(Exception ex)
            //{
            //    MessageBox.Show("Unable to Open database Error !  "+Environment.NewLine + ex);
            //}
        }

      
        private void Submit_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                if (feesmtto.Text == null || fee.Text == null || feetype.Text == "Select Fee Type" || feesmtto.Text == null || feeofmnth.Text == "Select Month" || feeamt.Text=="")
                {
                    MessageBox.Show("Please Fill Required Fields");
                }
                else
                {
                //    MessageBox.Show("Please Wait .." + Environment.NewLine + Environment.NewLine + "Saving data to online database It May Take Few Seconds");
               
                    try
                    {
                        string d = "server=naveen-pc;database=demo;Integrated Security=SSPI";
                        SqlConnection con = new SqlConnection(d);
                        con.Open();
                        string st = "INSERT INTO feesubmit values('" + id.Text + "','" + feeamt.Text + "','" + feeofmnth.Text + "','" + time.Text + "')";
                        SqlCommand cmd = new SqlCommand(st, con);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        Submit.Visible = false;
                        MessageBox.Show("Fee Submitted" + Environment.NewLine + " Please Take Print Out Of Recipt");
                        notice.Text = "I am " + feesmtto.Text + " Declare that the Student Id " + id.Text + " and Name " + name.Text + " Is Submitted Rs." + feeamt.Text + " His Fee.";
                        notice.Visible = true;
                        ft.Text = feetype.Text; fto.Text = feesmtto.Text;
                        fto.Text = feeofmnth.Text; idlbl.Visible = true; Idd.Text = id.Text; Idd.Visible = true; ft.Visible = true; fto.Visible = true; selmnth.Visible = true;
                        Check.Visible = false; id.Visible = false; errname.Visible = false; feetype.Visible = false; feesmtto.Visible = false; feeofmnth.Visible = false;
                        Save.Visible = true; print.Visible = true; bck.Visible = false; fee.Text = feeamt.Text; feeamt.Visible = false;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Unable To Submit Fee" + Environment.NewLine + ex);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please Accept The Declaration");
            }
            
        }

        private void feeofmnth_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void bck_Click(object sender, EventArgs e)
        {
            Administrator ad = new Administrator();
            ad.Show();
            Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dat = DateTime.Now;
            time.Text = dat.ToString();
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Red;
     
        }
        private void captureScreen()
        {
            try
            {
                // Call the CaptureAndSave method from the ScreenCapture class 
                // And create a temporary file in C:\Temp
                capScreen.CaptureAndSave(@"C:\root\test.png", CaptureMode.Window, ImageFormat.Png);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message.ToString());
            }
        }
        private void savePrint_Click(object sender, EventArgs e)
        {
        ////// Call your captureScreen() function
            close.Visible = false; print.Visible = false;
            Save.Visible = false;
            captureScreen();

           // Create new pdf document and page
           PdfDocument doc = new PdfDocument();
           PdfPage oPage = new PdfPage();
           close.Visible = true; print.Visible = true;
           // Add the page to the pdf document and add the captured image to it
           doc.Pages.Add(oPage);
           XGraphics xgr = XGraphics.FromPdfPage(oPage);
           XImage img = XImage.FromFile(@"C:\root\test.png");
           xgr.DrawImage(img, 0, 0);

            saveFileDialog.Filter = ("PDF File|*.pdf");
            DialogResult btnSave = saveFileDialog.ShowDialog();
            if (btnSave.Equals(DialogResult.OK))
            {
                doc.Save(saveFileDialog.FileName);
                doc.Close();
            }

             //I used the Dispose() function to be able to 
             //save the same form again, in case some values have changed.
             //When I didn't use the function, an GDI+ error occurred.
            img.Dispose(); close.Visible = true;
        }

        private void hpfprint_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(@"C:\root\test.png");
            Image img=bmp;

            e.Graphics.DrawImage(img,30,30,700,1000 );
        }


        private void print_Click(object sender, EventArgs e)
        {

            close.Visible = false; print.Visible = false; Save.Visible = false;
            capScreen.CaptureAndSave(@"C:\root\test.png", CaptureMode.Window, ImageFormat.Png);
        
            printPreviewDialog1.Document = hpfprint;
            printPreviewDialog1.ShowDialog();
            close.Visible = true; bck.Visible = true;

       
        }

        private void feetype_Leave(object sender, EventArgs e)
        {
            if (feetype.SelectedValue == "Late Fee" || feetype.SelectedValue == "Others")
            {
                feeofmnth.Items.Clear();
                feeofmnth.Items.Add("1st month");
                feeofmnth.Items.Add("2nd month");
                feeofmnth.Items.Add("3rd month");
                feeofmnth.Items.Add("4th month");
                feeofmnth.Items.Add("5th month");
                feeofmnth.Items.Add("6th month");
                feeofmnth.Items.Add("7th month");
                feeofmnth.Items.Add("8th month");
                feeofmnth.Items.Add("9th month");
                feeofmnth.Items.Add("10th month");
                feeofmnth.Items.Add("11th month");
                feeofmnth.Items.Add("12th month");
                
            }
            else if (feetype.SelectedValue == "Exam Fee")
            {
                feeofmnth.Items.Add("6th month");
                feeofmnth.Items.Add("12th month");
               
               
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Gray;
        }

        private void feesmtto_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void feeamt_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
