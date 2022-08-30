using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SimpleTCP;


namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SimpleTcpServer server;

        private void Form1_Load(object sender, EventArgs e)
        {
            server = new SimpleTcpServer();
            server.Delimiter = 0x13; //enter
            server.StringEncoder = Encoding.UTF8;
            server.DataReceived += Server_DataReceived;
        }

        public void Server_DataReceived(object sender, SimpleTCP.Message e)
        {
            statusTextBox.Invoke((MethodInvoker)delegate ()
            {
                statusTextBox.Text += e.MessageString;
                e.ReplyLine(string.Format("You Said: {0}", e.MessageString));
            });
            


        }

        private void startButton_Click(object sender, EventArgs e)
        {
            statusTextBox.Text = "Server Starting...";
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(HostTextBox.Text);
            server.Start(ip, Convert.ToInt32(portTextBox.Text));
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (!server.IsStarted)
            {
                server.Stop();
            }
        }
    }
}
