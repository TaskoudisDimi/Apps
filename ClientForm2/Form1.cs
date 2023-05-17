using System.Net.Sockets;
using System.Text;

namespace ClientForm2
{
    public partial class Form1 : Form
    {
        public Thread clientThread;
        public Socket client;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipAddress = ipTextBox.Text;
            int port;
            if(!int.TryParse(portTextBox.Text.ToString().Trim(), out port))
            {
                MessageBox.Show("Invalid port number.");
                return;
            }

            try
            {
                client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                client.Connect(ipAddress, port);
                logListBox.Items.Add("Connected to server." + Environment.NewLine);

                clientThread = new Thread(ReceiveMessages);
                clientThread.Start();


            }
            catch
            {

            }
        }

        private void ReceiveMessages(object? obj)
        {
            byte[] buffer = new byte[1024];
            int bytes;
            try
            {
                while((bytes = client.Receive(buffer)) > 0)
                {
                    byte[] receiveData = new byte[bytes];
                    Array.Copy(buffer, receiveData, bytes);
                    string receiveStringData = Encoding.UTF8.GetString(receiveData);

                    logListBox.Invoke(new Action(() =>
                    {
                        logListBox.Items.Add("Received message from server: " + receiveStringData + Environment.NewLine);
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
            if (client == null || !client.Connected)
            {
                MessageBox.Show("Not connected to the server.");
                return;
            }

            string message = messageTextBox.Text;
            byte[] messageData = Encoding.UTF8.GetBytes(message);
            client.Send(messageData);
            logListBox.Items.Add("Sent message to the server: " + message + Environment.NewLine);

            if (message.ToLower() == "exit")
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();

                logListBox.Items.Add("Disconnected from server." + Environment.NewLine);
            }

            messageTextBox.Clear();



        }
    }
}