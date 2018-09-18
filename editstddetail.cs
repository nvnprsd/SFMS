using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Demo
{
    public partial class editstddetail : Form
    {
        public editstddetail()
        {
            InitializeComponent();
            id.SelectAll();
            id.Focus();
            string k="";
        }

        private void back_Click(object sender, EventArgs e)
        {
            Administrator ad = new Administrator();
            ad.Show();
            Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Wait .." + Environment.NewLine + Environment.NewLine + "Getting data from online database It May Take Few Seconds");
           
            try
            {
                string strConn = "server=naveen-pc;database=demo;Integrated Security=SSPI";
                SqlConnection conn = new SqlConnection(strConn);
                conn.Open();
                string strSQL = "SELECT * FROM stdreg WHERE StdID="+id.Text+"";
                SqlCommand cmd = new SqlCommand(strSQL, conn);
                SqlDataReader dtr = cmd.ExecuteReader();
                dtr.Read();
                    name.Text = dtr["CandidateName"].ToString();
                    fname.Text = dtr["FatherName"].ToString();
                    mname.Text = dtr["MotherName"].ToString();
                    dob.Text = dtr["DateOfBirth"].ToString();
                    aadhar.Text = dtr["Uidai"].ToString();
                    gaadhar.Text = dtr["gUidai"].ToString();
                    passex.Text = dtr["LastpassEx"].ToString();
                    perex.Text = dtr["perOfEx"].ToString();
                    mobnum.Text = dtr["MobileNumber"].ToString();
                    gmobnum.Text = dtr["Gmobile"].ToString();
                    commadd.Text = dtr["ComAdd"].ToString();
                    peradd.Text = dtr["perAdd"].ToString();
                    selrel.Text = dtr["Relign"].ToString();
                    selcat.Text = dtr["cata"].ToString();
                    ctype.Text = dtr["ctype"].ToString();
                    cdur.Text = dtr["Cdur"].ToString();
                    stime.Text = dtr["Stime"].ToString();
                    byte[] img1 = ((byte[])dtr["CandPic"]);
                    MemoryStream ms = new MemoryStream(img1);
                    cimg.Image = Image.FromStream(ms);
                    byte[] img2 = ((byte[])dtr["GcandPic"]);
                    MemoryStream ms2 = new MemoryStream(img2);
                    gimg.Image = Image.FromStream(ms2);
                    byte[] img3 = ((byte[])dtr["candsign"]);
                    MemoryStream ms3 = new MemoryStream(img3);
                    simg.Image = Image.FromStream(ms3);
                 
                 
     //               string st=dtr["StdID"].ToString();          cimg.ImageLocation = @"E:\Demosoft\candpic"+st+".jpg";gimg.ImageLocation=@"E:\Demosoft\gpic"+st+".jpg"; simg.ImageLocation = @"E:\Demosoft\candsign" + st + ".jpg";
                    //panel2.Visible = false;
                
            }
            catch
            {
            }
        }
        private void passex_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void update_Click(object sender, EventArgs e)
        {
           
            try
            {
                byte[] img1 = null;
                FileStream str = new FileStream(cimg.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs = new BinaryReader(str);
                img1 = brs.ReadBytes((int)str.Length);

                byte[] img2 = null;
                FileStream str2 = new FileStream(gimg.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs2 = new BinaryReader(str2);
                img2 = brs2.ReadBytes((int)str2.Length);

                byte[] img3 = null;
                FileStream str3 = new FileStream(simg.ImageLocation, FileMode.Open, FileAccess.Read);
                BinaryReader brs3 = new BinaryReader(str3);
                img3 = brs3.ReadBytes((int)str3.Length);

                string cm = "update stdreg set Candidatename='" + name.Text + "',Fathername='" + fname.Text + "',mothername='" + mname.Text + "',dateofbirth='" + dob.Text + "',uidai='" + aadhar.Text + "',guidai='" + gaadhar.Text + "',lastpassex='" + passex.SelectedItem + "',perofex='" + perex.Text + "',mobilenumber='" + mobnum.Text + "',gmobile='" + gmobnum.Text + "',comadd='" + commadd.Text + "',peradd='" + peradd.Text + "',relign='" + selrel.SelectedItem + "',cata='" + selcat.SelectedItem + "',ctype='" + ctype.SelectedItem + "',cdur='" + cdur.SelectedItem + "',stime='" + stime.SelectedItem + "',candpic=@img1 ,gcandpic=@img2,candsign=@img3 where StdID=" + id.Text + "";
                string cmm = "update stdregm set Candidatename='" + name.Text + "',Fathername='" + fname.Text + "',mothername='" + mname.Text + "',dateofbirth='" + dob.Text + "',uidai='" + aadhar.Text + "',guidai='" + gaadhar.Text + "',lastpassex='" + passex.SelectedItem + "',perofex='" + perex.Text + "',mobilenumber='" + mobnum.Text + "',gmobile='" + gmobnum.Text + "',comadd='" + commadd.Text + "',peradd='" + peradd.Text + "',relign='" + selrel.SelectedItem + "',cata='" + selcat.SelectedItem + "',ctype='" + ctype.SelectedItem + "',cdur='" + cdur.SelectedItem + "',stime='" + stime.SelectedItem + "',candpic=@img1 ,gcandpic=@img2,candsign=@img3 where StdID=" + id.Text + "";
                SqlConnection con = new SqlConnection("server=naveen-pc;database=Demo;Integrated Security=SSPI");
                con.Open();
                SqlCommand cmd = new SqlCommand(cm, con);
                SqlCommand cmdm = new SqlCommand(cmm, con);
             
                cmd.Parameters.Add(new SqlParameter("@img1", img1));
                cmdm.Parameters.Add(new SqlParameter("@img1", img1));
                cmd.Parameters.Add(new SqlParameter("@img2", img2));
                cmdm.Parameters.Add(new SqlParameter("@img2", img2));
                cmd.Parameters.Add(new SqlParameter("@img3", img3));
                cmdm.Parameters.Add(new SqlParameter("@img3", img3));
                cmd.ExecuteNonQuery();
                cmdm.ExecuteNonQuery();
                con.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show("Update Unsucessful Try After Sometime Eror Code ! "+Environment.NewLine +ex);
            }

        }

        private void spic_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "images |*.jpg; *jpeg; *png; *gif";
                DialogResult dr = of.ShowDialog();
               cimg.Image = Image.FromFile(of.FileName);

            }
            catch
            {
            }
        }

        private void gpic_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "images |*.jpg; *jpeg; *png; *gif";
                DialogResult dr = of.ShowDialog();
                gimg.Image = Image.FromFile(of.FileName);

            }
            catch
            {
            }

        }

        private void ssg_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog of = new OpenFileDialog();
                of.Filter = "images |*.jpg; *jpeg; *png; *gif";
                DialogResult dr = of.ShowDialog();
                simg.Image = Image.FromFile(of.FileName);

            }
            catch
            {
            }
        }

        private void back_Click_1(object sender, EventArgs e)
        {
            Administrator ad = new Administrator();
            ad.Show();
            Hide();
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Red;
     
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Red;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.DeepSkyBlue;
        } 
     }
}
