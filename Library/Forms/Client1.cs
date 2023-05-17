using Library;
using Newtonsoft.Json;
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

namespace Forms.Forms
{
    public partial class Client1 : Form
    {
        private Socket _clientSocket;
        private Thread _receiveThread;

        public Client1()
        {
            InitializeComponent();
        }

        private void Client1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipAddress = ipTextBox.Text.Trim();
            int port;

            if (!int.TryParse(portTextBox.Text.Trim(), out port))
            {
                MessageBox.Show("Invalid port number.");
                return;
            }

            try
            {
                _clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _clientSocket.Connect(ipAddress, port);

                logListBox.Items.Add("Connected to server." + Environment.NewLine);

                _receiveThread = new Thread(ReceiveMessages);
                _receiveThread.Start();

                button1.Enabled = false;
            }
            catch (SocketException ex)
            {
                MessageBox.Show("Connection error: " + ex.Message);
            }
        }

        private void ReceiveMessages()
        {
            byte[] buffer = new byte[1024];
            int bytesRead;

            try
            {
                while ((bytesRead = _clientSocket.Receive(buffer)) > 0)
                {
                    byte[] receivedData = new byte[bytesRead];
                    Array.Copy(buffer, receivedData, bytesRead);

                    string receivedMessage = Encoding.ASCII.GetString(receivedData);
                    logListBox.Invoke(new Action(() =>
                    {
                        logListBox.Items.Add("Received message from server: " + receivedMessage + Environment.NewLine);
                    }));
                }
            }
            catch (SocketException)
            {
                logListBox.Invoke(new Action(() =>
                {
                    logListBox.Items.Add("Disconnected from server." + Environment.NewLine);
                }));
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_clientSocket == null || !_clientSocket.Connected)
            {
                MessageBox.Show("Not connected to the server.");
                return;
            }

            string message = messageTextBox.Text.Trim();

            byte[] buffer = Encoding.ASCII.GetBytes(message);
            _clientSocket.Send(buffer);

            logListBox.Items.Add("Sent message to the server: " + message + Environment.NewLine);

            if (message.ToLower() == "exit")
            {
                _clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();

                logListBox.Items.Add("Disconnected from server." + Environment.NewLine);
            }

            messageTextBox.Clear();
        }
    }
}
