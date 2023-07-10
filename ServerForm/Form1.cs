using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ServerForm
{
    public partial class Form1 : Form
    {
        private List<Socket> _clients = new List<Socket>();
        private readonly object _lock = new object();
        private Socket _serverSocket;
        private Thread _serverThread;
        public Form1()
        {
            InitializeComponent();
        }


        private void StartServer()
        {
            while (true)
            {
                Socket clientSocket = _serverSocket.Accept();
                lock (_lock)
                {
                    pictureBox1.BackColor = Color.LightGreen;
                    _clients.Add(clientSocket);
                    countLabel.Invoke(new Action(() =>
                    {
                        countLabel.Text = $"{_clients.Count}";
                    }));
                }

                Thread clientThread = new Thread(() => HandleClient(clientSocket));
                clientThread.Start();
            }
        }

        private void HandleClient(Socket clientSocket)
        {
            byte[] buffer;

            int length = Convert.ToInt32(1024);
            buffer = new byte[length];
            int bytesRead;

            try
            {
                while ((bytesRead = clientSocket.Receive(buffer)) > 0)
                {
                    byte[] receivedData = new byte[bytesRead];
                    Array.Copy(buffer, receivedData, bytesRead);

                    //string receivedMessage = Encoding.ASCII.GetString(receivedData);
                    
                    string jsonData = Encoding.UTF8.GetString(receivedData);

                    // Parse the JSON string into a JsonDocument
                    JsonDocument jsonDocument = JsonDocument.Parse(jsonData);

                    // Access the root element of the JSON array
                    JsonElement root = jsonDocument.RootElement;
                    string newValue = "";

                    foreach (JsonElement element in root.EnumerateArray())
                    {
                        // Access the properties dynamically
                        int rowIndex = element.GetProperty("RowIndex").GetInt32();
                        int columnIndex = element.GetProperty("ColumnIndex").GetInt32();
                        newValue = element.GetProperty("NewValue").GetString();

                    }
                    logListBox.Invoke(new Action(() =>
                    {
                        logListBox.Items.Add("Received message from client: " + newValue);
                    }));
   
                    BroadcastToClients(clientSocket, jsonData);
                }
            }
            catch (SocketException)
            {
                lock (_lock)
                {
                    _clients.Remove(clientSocket);
                }
                logListBox.Invoke(new Action(() =>
                {
                    logListBox.Items.Add("Client disconnected.");
                }));
            }
        }

        private void BroadcastToClients(Socket senderSocket, string message)
        {
            byte[] buffer = Encoding.ASCII.GetBytes(message);
            lock (_lock)
            {
                foreach (Socket client in _clients)
                {
                    if (client != senderSocket)
                        client.Send(buffer);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            logListBox.Items.Add("Server started. Waiting for connections..." + Environment.NewLine);
        }

        private void startButton_Click_1(object sender, EventArgs e)
        {
            _serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _serverSocket.Bind(new IPEndPoint(IPAddress.Any, 1234));
            _serverSocket.Listen(10);

            _serverThread = new Thread(StartServer);
            _serverThread.Start();

            startButton.Enabled = false;
            logListBox.Items.Add("Server started listening on port 1234.");
        }
    }

}