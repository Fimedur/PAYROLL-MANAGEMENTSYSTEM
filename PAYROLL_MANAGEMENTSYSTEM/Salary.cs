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
    public partial class Salary : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PR2;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        public Salary()
        {
            InitializeComponent();
        }
        void Display3()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select *from salary", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);
            // dv.Sort = "date  desc";
            //dataGridView1.Rows.Clear();
            dataGridView3.Columns.Clear();
            dataGridView3.DataSource = dv;


        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {
            Display3();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox14.Text = (float.Parse(textBox5.Text) - float.Parse(textBox8.Text)).ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Administrator_Form object2 = new Administrator_Form();
            object2.Show();
            this.Hide();
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 object3 = new Form1();
            object3.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (float.Parse(textBox7.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (float.Parse(textBox7.Text) + float.Parse(textBox10.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (float.Parse(textBox7.Text) + float.Parse(textBox10.Text) + float.Parse(textBox11.Text) + float.Parse(textBox12.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox8.Text = (float.Parse(textBox7.Text) + float.Parse(textBox10.Text) + float.Parse(textBox11.Text) + float.Parse(textBox12.Text)).ToString();
            }
            catch
            {

            }
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            try {
                textBox8.Text = (float.Parse(textBox7.Text) + float.Parse(textBox10.Text) + float.Parse(textBox11.Text) + float.Parse(textBox12.Text) + float.Parse(textBox13.Text)).ToString();
                }
            catch
            {

            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = (float.Parse(textBox3.Text)).ToString();
            }
            catch
            {

            }
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try {
                textBox5.Text = (float.Parse(textBox3.Text) + float.Parse(textBox4.Text) ).ToString();
            }
            catch
            {

            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                textBox5.Text = (float.Parse(textBox3.Text) + float.Parse(textBox4.Text) + float.Parse(textBox6.Text)).ToString();
            }
            catch
            {

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            
            con.Open();
            string sqlQuery = "Insert into salary(eid,name,acNo,Jdate,c_month,bsalary,nsalary)VALUES('" + textBox2.Text + "', '" + textBox1.Text + "','" + textBox9.Text + "', '" +dateTimePicker1.Text+ "','" + textBox15.Text + "', '" + textBox3.Text + "','"+textBox14.Text+"') ";
            cmd = new SqlCommand(sqlQuery, con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Datas Save Successfully........");
            Display3();
        }

        private void dataGridView3_MouseClick(object sender, MouseEventArgs e)
        {


            textBox2.Text = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            textBox1.Text = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
            textBox9.Text = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
            textBox15.Text = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
            textBox3.Text = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
            textBox14.Text = dataGridView3.SelectedRows[0].Cells[6].Value.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM salary WHERE (eid = '" + textBox2.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Susscefully Delete...... :)");
            Display3();
           // refresh();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"UPDATE       salary
            SET         acNo ='" + textBox9.Text + "' ,c_month='" + textBox15.Text + "',nsalary='" + textBox14.Text + "' WHERE (eid = '" + textBox2.Text + "' )", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successfully.......");
            Display3();
            //refresh();
        }

       
    }
}
