using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAYROLL_MANAGEMENTSYSTEM
{
    public partial class Administrator_Form : Form
    {
        public Administrator_Form()
        {
            InitializeComponent();
        }

        private void Administrator_Form_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           Form1 objectk = new Form1();
            objectk.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LISTVIEW objectlistv = new LISTVIEW();
            this.Hide();
            objectlistv.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee_Details obj = new Employee_Details();
            obj.Show();
            this.Hide();
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Salary objectsalary = new Salary();
            objectsalary.Show();
            this.Hide();
          
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Leave objectl = new Leave();
            objectl.Show();
            this.Hide();
        }
    }
}
