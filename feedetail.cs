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
    public partial class feedetail : Form
    {
        public feedetail()
        {
            InitializeComponent();
        }

        private void getdetail_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Please Wait .." + Environment.NewLine + Environment.NewLine + "Getting data from online database It May Take Few Seconds");
            try
            {

                string k = "select * from feesubmit where StdId='" +id.Text+ "'";
                string d = "server=naveen-pc;database=demo;Integrated Security=SSPI";
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
                MessageBox.Show("Online Database Connection Not Established. Error!  Code-" + ex);
            }
        }

        private void comboBox1_Leave(object sender, EventArgs e)
        {
            if (comboBox1.Text == "View All Students Fee Details")
            {
                id.Visible = false;
                errid.Visible = false;getdetail.Visible=false;

                //MessageBox.Show("Please Wait .." + Environment.NewLine + Environment.NewLine + "Getting data from online database It May Take Few Seconds");
           
                try
                {

                    string k = "select * from feesubmit";
                    string d = "server=naveen-pc;database=Demo;Integrated Security=SSPI";
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
                    MessageBox.Show("Online Database Connection Not Established. Error!  Code-" + ex);
                }
            }
            else
            {
                id.Visible = true;
                errid.Visible=true;
                id.Focus();
            }
        }

        private void close_MouseHover(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Red;
        }

        private void close_MouseLeave(object sender, EventArgs e)
        {
            close.BackColor = System.Drawing.Color.Transparent;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void back_Click(object sender, EventArgs e)
        {
            Administrator f = new Administrator();
            this.Hide();
            f.Show();
        
        }

        private void id_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
