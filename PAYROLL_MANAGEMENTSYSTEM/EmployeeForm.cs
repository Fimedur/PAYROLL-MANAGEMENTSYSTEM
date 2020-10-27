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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void personalDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EDetails ed = new EDetails();
            ed.Show();
        }

        private void passwordToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //
            if (MessageBox.Show(" are you sure about to close this application ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                this.Close();

            }

            if (MessageBox.Show(" are you sure about to close this application ? ", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)


            {
                MessageBox.Show("you clicked no ");
                Refresh();
            }
            //
            ChangePasswordForm objectc = new ChangePasswordForm();
            objectc.Show();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

          
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripSeparator1_Click(object sender, EventArgs e)
        {

        }

        private void presentPasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void onlineHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.facebook.com/");
        }

        private void mailToAdministratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MailingForm mf = new MailingForm();
            mf.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 of1 = new Form1();
            of1.Show();
        }

        private void eXITToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void allowancesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paymentDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void termsAndConditionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            //Leave_info lv = new Leave_info();
            //lv.Show();
        }

        private void absenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.Hide();
            Leave_info lv = new Leave_info();
            lv.Show();
        }

        private void payslipToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salary_info si = new Salary_info();
            si.Show();
        }
    }
}
