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

namespace UDPClient
{


    public partial class UDPClient : Form
    {

        UdpClient client;
        IPEndPoint endPoint;

        public UDPClient()
        {
            InitializeComponent();



        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            int serverPort = int.Parse(hostPortTextBox.Text);
            int clientPort = int.Parse(ClientPortTextBox.Text);

            string hostName = hostTextBox.Text;

            client = new UdpClient(clientPort);

            string msg = clientPort + "." + hostName + "." + messageTextBox.Text;
            byte[] buffer = Encoding.Unicode.GetBytes(msg);

            client.Send(buffer, buffer.Length, hostName, serverPort);

            endPoint = new IPEndPoint(IPAddress.Any, 0);
            buffer = client.Receive(ref endPoint);

            msg = Encoding.Unicode.GetString(buffer);

            statusTextBox.AppendText("Server Said : " + msg + Environment.NewLine);

            Writelog(msg);

        }

        private void Writelog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { statusTextBox.AppendText("Server Said : " + msg + Environment.NewLine);  });
            this.BeginInvoke(invoker);
                
        }
    }
}

