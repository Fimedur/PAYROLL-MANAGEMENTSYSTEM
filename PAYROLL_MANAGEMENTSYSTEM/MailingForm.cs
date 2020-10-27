using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Mail;
using System.Net.Mime;

namespace PAYROLL_MANAGEMENTSYSTEM
{
    public partial class MailingForm : Form
    {
        public MailingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                SmtpClient Client = new SmtpClient("smtp.gmail.com",587);
                Client.EnableSsl = true;
                Client.Timeout = 10000;
                Client.DeliveryMethod = SmtpDeliveryMethod.Network;
                Client.UseDefaultCredentials = false;
                Client.Credentials = new NetworkCredential("nh.limon2010@gmail.com","lornlmn22");
                MailMessage msg = new MailMessage();
  
                msg.To.Add(textBoxTo.Text);
                msg.From = new MailAddress("nh.limon2010@gmail.com");
                msg.Subject = textBoxSubject.Text;
                msg.Body = textBoxBody.Text;
                Client.Send(msg);
                MessageBox.Show("Sent Succesfully");





            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void MailingForm_Load(object sender, EventArgs e)
        {

        }
    }
}
