using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoSalonn
{
    public partial class SendMailForm : Form
    {
        public SendMailForm()
        {
            InitializeComponent();
        }

        private void ExitBbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            MailAddress fromMailAddress = new MailAddress("auto.uln.22@mail.ru");

            if (AdressTextBox.Text == "")
            {
                MessageBox.Show("Введите адрес электронной почты");
            }
            else
            {
                MailAddress toMailAddress = new MailAddress(AdressTextBox.Text);

                using (MailMessage mailMessage = new MailMessage(fromMailAddress, toMailAddress))

                using (SmtpClient smtpClient = new SmtpClient())
                {
                    mailMessage.Subject =  "Ваш список избранного";
                    mailMessage.Body = "Здравствуйте. " + Environment.NewLine + "Мы прислали Вам список выбранных автомобилей в нашем приложении.";
                    mailMessage.IsBodyHtml = true;

                    

                    File.AppendAllText("Избранное.csv", "Название,Количество,Цена");
                    foreach(KeyValuePair<Car, int> myCar in SelectedForm.MyCars)
                    {
                        Car car = myCar.Key;
                        File.AppendAllText("Избранное.csv",
                            Environment.NewLine +
                            car.name + "," + myCar.Value + "," + car.price);
                    }

                    mailMessage.Attachments.Add(new Attachment("Избранное.csv"));

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
