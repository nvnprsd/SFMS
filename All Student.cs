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

namespace Demo
{
    public partial class All_Student : Form
    {
        public All_Student()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void All_Student_Load(object sender, EventArgs e)
        {
           
            try
            {
             
                string k = "select stdid As ID, CandidateName as Name,  FatherName As Fname, MotherName as Mname,uidai as UIDAI,ComAdd as Address, DateOfBirth as DOB,MobileNumber as Mob,Gmobile as [ P Mobile],ctype as Type,cdur as Duration,Stime as Timing from stdreg ";
                string d = "server=naveen-pc;database=demo;Integrated Security=SSPI";
               // MessageBox.Show("Please Wait .." + Environment.NewLine + Environment.NewLine + "Getting data from online database It May Take Few Seconds");
           
                SqlConnection con = new SqlConnection(d);
                SqlCommand cmd = new SqlCommand(k, con);
                con.Open();
                SqlDataAdapter ad = new SqlDataAdapter();
                ad.SelectCommand = cmd;
                DataTable dt = new DataTable();
                ad.Fill(dt);
                dataGridView1.DataSource = dt;
               

            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Connect  Database Error! "+Environment.NewLine+ex);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Administrator ad = new Administrator();
            ad.Show();
            Hide();
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Red;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Transparent;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
