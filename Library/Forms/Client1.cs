using Library;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Forms.Forms
{
    public partial class Client1 : Form
    {
        private Socket _clientSocket;
        private Thread _receiveThread;
        private List<DataGridViewCellChange> changedCells = new List<DataGridViewCellChange>();
        public Client1()
        {
            InitializeComponent();
        }

        private void Client1_Load(object sender, EventArgs e)
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From ProductTbl");
            dataGridView1.DataSource = loaddata.table;

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
                        dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = newValue;

                    }
                    //string receivedMessage = Encoding.ASCII.GetString(receivedData);

                    logListBox.Invoke(new Action(() =>
                    {
                        logListBox.Items.Add("Received message from server: " + newValue + Environment.NewLine);
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

            //string message = messageTextBox.Text;
            //byte[] messageData = Encoding.UTF8.GetBytes(message);

            string jsonData = System.Text.Json.JsonSerializer.Serialize(changedCells);
            byte[] jsonToBytes = Encoding.UTF8.GetBytes(jsonData);

            string message = "";
            foreach (DataGridViewCellChange data in changedCells)
            {
                message = data.NewValue;
            }

            _clientSocket.Send(jsonToBytes);
            logListBox.Items.Add("Sent message to the server: " + message + Environment.NewLine);

            if (message.ToLower() == "exit")
            {
                _clientSocket.Shutdown(SocketShutdown.Both);
                _clientSocket.Close();

                logListBox.Items.Add("Disconnected from server." + Environment.NewLine);
            }

            messageTextBox.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = 1;
            int columnIndex = 1;
            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = "22";
            int rowIndex2 = 1;
            int columnIndex2 = 4;
            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = "2222";

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            var changeCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
            var change = new DataGridViewCellChange
            {
                RowIndex = e.RowIndex,
                ColumnIndex = e.ColumnIndex,
                NewValue = changeCell.Value.ToString()
            };
            changedCells.Add(change);
        }
    }

    public class DataGridViewCellChange
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public string NewValue { get; set; }
    }

}
