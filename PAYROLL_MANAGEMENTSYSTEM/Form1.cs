using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PAYROLL_MANAGEMENTSYSTEM
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PR2;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        public Form1()
        {
            InitializeComponent();
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (radioButton1.Checked)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From ee_info where (name='" + textBox1.Text + "' and eid = '" + textBox2.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Succesfully logged in ");

                    this.Hide();

                    EmployeeForm ef = new EmployeeForm();
                    ef.Show();
                }
                con.Close();
            }
            else if (radioButton2.Checked)
            {
                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("Select count(*) From admin where (a_name='" + textBox1.Text + "'and aid= '" + textBox2.Text + "')", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Succesfully logged in ");

                    this.Hide();

                    Administrator_Form af = new Administrator_Form();
                    af.Show();
                }
                con.Close();
            }
            else
            {
                MessageBox.Show("Please cheak your user name & password ........");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            EmployeeForm objectef =new  EmployeeForm();
            this.Hide();
            objectef.Show();
            

        }
    }
}
