using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace ClientForm2
{
    public partial class Form1 : Form
    {
        public Thread clientThread;
        public Socket client;
        private List<DataGridViewCellChange> changedCells = new List<DataGridViewCellChange>();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ipAddress = ipTextBox.Text;
            int port;
            if (!int.TryParse(portTextBox.Text.ToString().Trim(), out port))
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
            int bytesRead;

            try
            {
                while ((bytesRead = client.Receive(buffer)) > 0)
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
            if (client == null || !client.Connected)
            {
                MessageBox.Show("Not connected to the server.");
                return;
            }

            //string message = messageTextBox.Text;
            //byte[] messageData = Encoding.UTF8.GetBytes(message);

            string jsonData = JsonSerializer.Serialize(changedCells);
            byte[] jsonToBytes = Encoding.UTF8.GetBytes(jsonData);

            string message = "";
            foreach (DataGridViewCellChange data in changedCells)
            {
                message = data.NewValue;
            }

            client.Send(jsonToBytes);
            logListBox.Items.Add("Sent message to the server: " + message + Environment.NewLine);

            if (message.ToLower() == "exit")
            {
                client.Shutdown(SocketShutdown.Both);
                client.Close();

                logListBox.Items.Add("Disconnected from server." + Environment.NewLine);
            }

            messageTextBox.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From ProductTbl");
            dataGridView1.DataSource = loaddata.table;
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

        private void button3_Click(object sender, EventArgs e)
        {
            int rowIndex = 1;
            int columnIndex = 1;
            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = "11";
            int rowIndex2 = 1;
            int columnIndex2 = 4;
            dataGridView1.Rows[rowIndex].Cells[columnIndex].Value = "1111";
        }
    }
    public class DataGridViewCellChange
    {
        public int RowIndex { get; set; }
        public int ColumnIndex { get; set; }
        public string NewValue { get; set; }
    }
}