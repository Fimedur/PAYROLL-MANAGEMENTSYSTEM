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
    public partial class Leave : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PR2;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        public Leave()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void Leave_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Administrator_Form object1 = new Administrator_Form();
            object1.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 objectmain = new Form1();
            objectmain.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

            try
            {
                textBox7.Text = (float.Parse(textBox1.Text) + float.Parse(textBox2.Text) + float.Parse(textBox3.Text) + float.Parse(textBox4.Text) + float.Parse(textBox5.Text)).ToString();
            }
            catch
            {

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlQuery = "Insert into leave(eid,s_leave,c_leave,p_leave,u_leave,total_leave)VALUES('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text + "', '" + textBox4.Text + "','" + textBox5.Text + "', '" + textBox7.Text + "') ";
            cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Datas Save Successfully........");
        }
    }
}
