using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace UDPServer
{
    public partial class UDPServer : Form
    {

        UdpClient server;
        IPEndPoint endPoint;


        public UDPServer()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {

            server = new UdpClient(int.Parse(HostTextBox.Text));
            endPoint = new IPEndPoint(IPAddress.Any, 0);


            Writelog("Server Started...");


            Thread thread = new Thread(new ThreadStart(ServerStart));
            thread.Start();

            startButton.Enabled = false;            
        }

        private void ServerStart()
        {
            while (true)
            {
                byte[] buffer = server.Receive(ref endPoint);

                string[] msg = Encoding.Unicode.GetString(buffer).Split('.');

                Writelog("Client at Port : " + msg[0]);
                Writelog("at host : " + msg[1]);
                Writelog("need : " + msg[2]);


                buffer = Encoding.Unicode.GetBytes(DateTime.Now.ToString());

                server.Send(buffer, buffer.Length, msg[1], int.Parse(msg[0]));


            }
        }


        private void Writelog(string msg)
        {
            MethodInvoker invoker = new MethodInvoker(delegate { statusTextBox.AppendText("Server Said : " + msg + Environment.NewLine); });
            this.BeginInvoke(invoker);

        }

        private void newClientButton_Click(object sender, EventArgs e)
        {
            UDPClient client = new UDPClient();
            client.Show();

        }
    }
}
