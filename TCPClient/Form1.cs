using SimpleTCP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace TCPClient
{
    public partial class Form1 : Form
    {
        System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            msg("Client Started");
            client.Connect("127.0.0.1", 8888);

        }

        private void sendButton_Click(object sender, EventArgs e)
        {
           NetworkStream serverStream = client.GetStream();
           byte[] outStream = System.Text.Encoding.ASCII.GetBytes(ToServerTextBox.Text + "$");
           serverStream.Write(outStream, 0, outStream.Length);
           serverStream.Flush();
           byte[] inStream = new byte[10025];
           serverStream.Read(inStream, 0, (int)client.ReceiveBufferSize);
           string returndata = System.Text.Encoding.ASCII.GetString(inStream);
           msg(returndata);
           ToServerTextBox.Text = "";
           ToServerTextBox.Focus();

        }
        public void msg(string mesg)
        {
            ToServerTextBox.Text = ToServerTextBox.Text + Environment.NewLine + " >> " + mesg;
        }
        private void connectButton_Click(object sender, EventArgs e)
        {

        }

    }
}
