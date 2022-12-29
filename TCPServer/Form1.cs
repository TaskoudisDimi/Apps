using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using SimpleTCP;

namespace TCPServer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            
        }
        
        private void startButton_Click(object sender, EventArgs e)
        {
            TcpListener server = new TcpListener(8888);
            int reqCount = 0;
            TcpClient client = default(TcpClient);
            server.Start();
            textBox.Text = "Server is started...";
            
            client = server.AcceptTcpClient();
            textBox.Text = "Accept connection from client...";

            while (true)
            {
                try
                {
                   
                    reqCount++;
                    NetworkStream stream = client.GetStream();
                    byte[] bytesFrom = new byte[10025];
                    stream.Read(bytesFrom, 0, (int)client.ReceiveBufferSize);
                    string dataFromClient = System.Text.Encoding.ASCII.GetString(bytesFrom);
                    dataFromClient = dataFromClient.Substring(0, dataFromClient.IndexOf("$"));
                    messageTextBox.Text = dataFromClient;
                    string serverResponse = "Last Message from Client" + dataFromClient;
                    Byte[] sendbytes = Encoding.ASCII.GetBytes(serverResponse);
                    stream.Write(sendbytes, 0, sendbytes.Length);
                    stream.Flush();
                    messageTextBox.Text = serverResponse;


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            

        }


    }


}
