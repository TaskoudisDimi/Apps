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

namespace UDPClient
{
    public partial class Form1 : Form
    {
        private UdpClient udpClient;
        private IPEndPoint serverEndPoint;

        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
           

        }


        private void disconnectButton_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            udpClient = new UdpClient();

            // Bind the client socket to an available port
            udpClient.Client.Bind(new IPEndPoint(IPAddress.Any, 0));

            serverEndPoint = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8080); // Set the server IP address and port number

            // Start receiving messages asynchronously
            udpClient.BeginReceive(ReceiveCallback, null);

        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            byte[] receivedBytes = udpClient.EndReceive(ar, ref serverEndPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

            // Display the received message in the UI
            Invoke(new Action(() =>
            {
                statusTextBox.AppendText($"Received: {receivedMessage}{Environment.NewLine}");
            }));

            // Continue receiving messages
            udpClient.BeginReceive(ReceiveCallback, null);

        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);

            // Send the message to the server
            udpClient.Send(messageBytes, messageBytes.Length, serverEndPoint);

            // Display the sent message in the UI
            statusTextBox.AppendText($"Sent: {message}{Environment.NewLine}");
            messageTextBox.Clear();
        }
    }
}
