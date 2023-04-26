using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoSalonn
{
    public partial class FeedBackForm : Form
    {
        public FeedBackForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("auto.uln.22@mail.ru");

            if (comboBox1.Text == "")
            {
                MessageBox.Show("Выберите тему сообщения");
            }
            else
            { 
                MailAddress toMailAddress = new MailAddress("auto.uln.22@mail.ru");

                using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))

                using (SmtpClient smtpClient = new SmtpClient())
                {
                    mailMessage.Subject = comboBox1.Text;
                    mailMessage.Body = textBox1.Text;
                    mailMessage.IsBodyHtml = true;

                    smtpClient.Host = "smtp.mail.ru";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromMailAddress.Address, "frhSL7jH55yCdu7MAjpf");

                    smtpClient.Send(mailMessage);
                }
                MessageBox.Show("Письмо отправлено");
                Close();
            }

        }
    }
}
