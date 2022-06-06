using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCPClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpClient client;

        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(hostTextBox.Text);
            client.Connect(hostTextBox.Text, Convert.ToInt32(portTextBox.Text));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;
        }

        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            statusTextBox.Invoke((MethodInvoker)delegate ()
            {
                statusTextBox.Text += e.MessageString;
            });
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(messageTextBox.Text, TimeSpan.FromSeconds(3));
        }
    }
}
