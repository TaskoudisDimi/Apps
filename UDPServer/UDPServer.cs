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

        private UdpClient udpServer;
        private IPEndPoint remoteEndPoint;
        private Dictionary<string, IPEndPoint> connectedClients;
        public UDPServer()
        {
            InitializeComponent();
            connectedClients = new Dictionary<string, IPEndPoint>();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            
        }

        private void ReceiveCallback(IAsyncResult ar)
        {
            byte[] receivedBytes = udpServer.EndReceive(ar, ref remoteEndPoint);
            string receivedMessage = Encoding.ASCII.GetString(receivedBytes);

            // Display the received message in the UI
            Invoke(new Action(() =>
            {
                statusTextBox.AppendText($"Received: {receivedMessage}{Environment.NewLine}");
            }));

            // Add or update client's endpoint in the dictionary
            string clientKey = $"{remoteEndPoint.Address}:{remoteEndPoint.Port}";
            connectedClients[clientKey] = remoteEndPoint;

            // Continue receiving messages
            udpServer.BeginReceive(ReceiveCallback, null);
        }



        private void UDPServer_FormClosing(object sender, FormClosingEventArgs e)
        {
           
           
        }

        private void sendButton_Click(object sender, EventArgs e)
        {
            string message = messageTextBox.Text;
            byte[] messageBytes = Encoding.ASCII.GetBytes(message);

            // Send the message to all connected clients
            foreach (var clientEndPoint in connectedClients.Values)
            {
                udpServer.Send(messageBytes, messageBytes.Length, clientEndPoint);
            }

            // Display the sent message in the UI
            statusTextBox.AppendText($"Sent: {message}{Environment.NewLine}");
            messageTextBox.Clear();

        }

        private void UDPServer_Load(object sender, EventArgs e)
        {
            udpServer = new UdpClient(8080); // Set the port number you want to listen on
            remoteEndPoint = new IPEndPoint(IPAddress.Any, 0);

            // Start receiving messages asynchronously
            udpServer.BeginReceive(ReceiveCallback, null);
        }

        
    }
}
