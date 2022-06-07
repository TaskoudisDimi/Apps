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

namespace Email
{
    public partial class Form1 : Form
    {
        NetworkCredential login;
        SmtpClient client;
        MailMessage msg;

        public Form1()
        {
            InitializeComponent();
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            login = new NetworkCredential(usernameTextBox.Text, passwordTextBox.Text);
            client = new SmtpClient(smtpTextBox.Text);
            client.Port = Convert.ToInt32(portTextBox.Text);
            client.EnableSsl = sslCheckBox.Checked;
            client.Credentials = login;
            msg = new MailMessage {From = new MailAddress(usernameTextBox.Text + smtpTextBox.Text.Replace("smtp.", "@"), "Dimitris", Encoding.UTF8) };
            msg.To.Add(new MailAddress(toTextBox.Text));
            if (!string.IsNullOrEmpty(CCTextBox.Text))
            {
                msg.To.Add(new MailAddress(CCTextBox.Text));

            }
            msg.Subject = subjectTextBox.Text;
            msg.Body = messageTextBox.Text;
            msg.BodyEncoding = Encoding.UTF8;
            msg.IsBodyHtml = true;
            msg.Priority = MailPriority.Normal;
            msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
            client.SendCompleted += new SendCompletedEventHandler(SendCompletedCallback);
            string userstate = "Sending";
            client.SendAsync(msg, userstate);
        }


        public static void SendCompletedCallback(object sender, AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show(string.Format("{0} send canceled.", e.UserState), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if(e.Error != null)
            {
                MessageBox.Show(string.Format("{0} {1}", e.UserState, e.Error), "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Your message has been succesfully send", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
    }
}
