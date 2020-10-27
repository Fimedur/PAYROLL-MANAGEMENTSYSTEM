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
using System.IO;


namespace PAYROLL_MANAGEMENTSYSTEM
{
    public partial class Employee_Details : Form
    {
        string gender;
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PR2;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd ;
        string imgLocation = "";

        public Employee_Details()
        {
            InitializeComponent();
            

        }
        void Display()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select *from ee_info", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);
            // dv.Sort = "date  desc";
            //dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.DataSource = dv;


        }

        /* void save()
         {
             if ((textBox1.Text == "") || (textBox2.Text == "") || (textBox3.Text == "") || (textBox4.Text == "") ||
               (textBox5.Text == "") || (textBox6.Text == "") || (textBox7.Text == "") || (pictureBox1.Image == null) ||
               (textBox9.Text == "") || (textBox10.Text == "") || (textBox11.Text == "") || (textBox12.Text == "") ||
               (textBox13.Text == "") || (textBox14.Text == "") || (textBox15.Text == "") || (textBox16.Text == "") ||
               (radioButton1.Checked == false) || (radioButton2.Checked == false) ||
               (dateTimePicker1.Text == ""))
                 MessageBox.Show("one or more Fields are Empty..!");
             else
             {
                 con.Open();
                 if(radioButton1.Checked)
                 {
                     gender = "Femeal";
                 }
                 else
                 {
                     gender = "Male";
                 }

                 con.Open();
                 SqlCommand cmd = new SqlCommand(@"INSERT employee_info (name,m_status,fname,sex,age,dob,address,blood_g,s_name,n_of_ch,dept,designation,b_salary,j_date,pic) 
 VALUES ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + gender +"','" + textBox5.Text + "','"+ dateTimePicker1 +"','" + textBox6.Text + "','" + textBox7.Text + "',' "+ textBox9.Text +"','"+ textBox10.Text + "'," + textBox11.Text + "'," + textBox12.Text + "'," + textBox13.Text + "'," + textBox14.Text + "'," + textBox15.Text + "'," + textBox16.Text + "','" +  +"')", con);
                 MemoryStream stream = new MemoryStream();
                 pictureBox1.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);

                 byte[] pic = stream.ToArray();
                 cmd.Parameters.AddWithValue("@pic", pic);
                 j = cmd.ExecuteNonQuery();

                 if (j > 0)
                 {

                     MessageBox.Show("Susscefully Save :)");
                 }
                 con.Close();

             }

         }*/
        private void Employee_Details_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 object3 = new Form1();
            object3.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Administrator_Form object2 = new Administrator_Form();
            object2.Show();
            this.Hide();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "png files(*.png)|*.png|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if(dialog.ShowDialog()==DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pictureBox1.ImageLocation = imgLocation;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            

            if (radioButton1.Checked)
            {
                gender = "Femeal";
            }
            else
            {
                gender = "Male";
            }

            con.Open();
            string sqlQuery = "Insert into ee_info(eid,name,ms,fmane,sex,age,dob,e_add,bg,smame,nfc,jtitle,dept,deg,eshift,bsalary,jdate,pic)VALUES('" + textBox1.Text + "', '" + textBox2.Text + "','" + textBox3.Text +"', '" + textBox4.Text + "', '" + gender + "', '" + textBox5.Text + "', '" + dateTimePicker1.Text + "', '" + textBox6.Text + "', '" + textBox7.Text + "','" + textBox9.Text +"', '" + textBox10.Text + "', '" + textBox11.Text + "','" + textBox12.Text + "', '" + textBox13.Text + "','" + textBox14.Text + "', '" + textBox15.Text + "','" + textBox16.Text + "', @images) ";
            cmd = new SqlCommand(sqlQuery, con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show( "Datas Save Successfully........");
            Display();
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {


            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            //textBox5.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox5.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

            textBox6.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            textBox7.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
            textBox9.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            textBox10.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
            textBox11.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
            textBox12.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();
            textBox13.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();

            textBox14.Text = dataGridView1.SelectedRows[0].Cells[14].Value.ToString();
            textBox15.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
            textBox16.Text = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
           // pictureBox1.Image = dataGridView1.SelectedRows[0].Cells[17].Value.GetHashCode();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            con.Open();
            string sqlQuery = "select pic from ee_info where eid = '" + textBox1.Text + "'";
            cmd = new SqlCommand(sqlQuery, con);
            SqlDataReader DataRead = cmd.ExecuteReader();
            DataRead.Read();

            if (DataRead.HasRows)
            {
                byte[] images = ((byte[])DataRead[0]);


                if (images == null)
                {
                    pictureBox1.Image = null;
                }
                else
                {
                    MemoryStream mstreem = new MemoryStream(images);
                    pictureBox1.Image = Image.FromStream(mstreem);
                }
            }
            else
            {
                MessageBox.Show("There is no image avilable ........");
            }
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(@"DELETE FROM ee_info WHERE (eid = '" + textBox1.Text + "')", con);
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Susscefully Delete...... :)");
            Display();
            //refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();

            byte[] images = null;
            FileStream Stream = new FileStream(imgLocation, FileMode.Open, FileAccess.Read);
            BinaryReader brs = new BinaryReader(Stream);
            images = brs.ReadBytes((int)Stream.Length);

            SqlCommand cmd = new SqlCommand(@"UPDATE       ee_info
            SET          name='" + textBox2.Text + "' ,ms='" + textBox3.Text + "',fmane='" + textBox4.Text + "',age='" + textBox5.Text + "',e_add='" + textBox6.Text + "',smame='" + textBox9.Text + "',nfc='" + textBox10.Text + "' ,jtitle='" + textBox11.Text + "',dept='" + textBox12.Text + "',deg='" + textBox13.Text + "',eshift='" + textBox14.Text + "',bsalary='" + textBox15.Text + "',pic = @images WHERE (eid = '" + textBox1.Text + "' )", con);
            cmd.Parameters.Add(new SqlParameter("@images", images));
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Update successfully.......");
            Display();
            //refresh();
        }
    }
}
