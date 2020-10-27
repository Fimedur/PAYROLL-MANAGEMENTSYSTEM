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
    public partial class LISTVIEW : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=PR2;Integrated Security=True");
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();
        SqlCommand cmd;
        public LISTVIEW()

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

        void Display2()
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select *from leave", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);

            DataView dv = new DataView(dt);
            // dv.Sort = "date  desc";
            //dataGridView1.Rows.Clear();
            dataGridView2.Columns.Clear();
            dataGridView2.DataSource = dv;


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
        private void LISTVIEW_Load(object sender, EventArgs e)
        {
            Display();
            Display2();
            Display3();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Administrator_Form objectback = new Administrator_Form();
            objectback.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 objectlogout = new Form1();
            objectlogout.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
