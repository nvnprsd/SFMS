using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
{
    public partial class Administrator : Form
    {
        public Administrator()
        {
            InitializeComponent();
        }



        private void studentlist_Click(object sender, EventArgs e)
        {
            if (Selecttime.SelectedItem == null)
            {
                MessageBox.Show("please select Timing");

            }
            else
            {
              //  MessageBox.Show("Plesase Wait " + Environment.NewLine + Environment.NewLine + "Getting Data From Online Database It May Take Few Seconds...");

                try
                {

                    string k = "select StdID, CandidateName as Name,  FatherName As Fname, MotherName as Mname,uidai as UIDAI,ComAdd as Address, DateOfBirth as DOB,MobileNumber as Contact,ctype as Course_Type,cdur as Course_Duration,Stime as Student_Timing from stdreg where stime='" + Selecttime.SelectedItem + "'";
                    string d = "server=naveen-pc;database=demo;Integrated Security=SSPI ";
                    SqlConnection con = new SqlConnection(d);
                    SqlCommand cmd = new SqlCommand(k, con);
                    con.Open();
                    SqlDataAdapter ad = new SqlDataAdapter();
                    ad.SelectCommand = cmd;
                    DataTable dt = new DataTable();
                    ad.Fill(dt);
                    datatable1.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database Connection Not Established. Error!  Code-" + ex);
                }
            }
        }
    

        private void Addnew_Click(object sender, EventArgs e)
        {
            Register f = new Register();
            this.Hide();
            f.Show();

        }

        private void home_Click(object sender, EventArgs e)
        {
            welcome f = new welcome();
            this.Hide();
            f.Show();
        }

        private void GenCert_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Alert ! Comming Soon.."+Environment.NewLine+"This Segment Available After Purchase ");
        }

      

        private void feesubmit_Click(object sender, EventArgs e)
        {
            Fee_Submit f = new Fee_Submit();
            this.Hide();
            f.Show();
        }

        private void viewall_Click(object sender, EventArgs e)
        {
            All_Student al = new All_Student();
            this.Hide();
            al.Show();

        }

        private void editstd_Click(object sender, EventArgs e)
        {
            editstddetail ed = new editstddetail();
            this.Hide();
            ed.Show();
        }

        private void remove_Click(object sender, EventArgs e)
        {
            removestd rm = new removestd();
            this.Hide();
            rm.Show(); 
        }

        private void vewfee_Click(object sender, EventArgs e)
        {
            feedetail fe = new feedetail();
            this.Hide();
            fe.Show();
        }
        
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Close();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Red;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.BackColor = System.Drawing.Color.Transparent;
        }  
    }
}
