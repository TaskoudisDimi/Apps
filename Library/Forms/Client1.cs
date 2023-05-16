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
        private Socket clientSocket;
        public Client1()
        {
            InitializeComponent();
        }

        private void Client1_Load(object sender, EventArgs e)
        {
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From ProductTbl");
            dataGridView1.DataSource = loaddata.table;


            //clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            //clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));


        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string data = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                byte[] buffer = Encoding.ASCII.GetBytes(data);
                clientSocket.Send(buffer);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Serialize the whole DataGridView data to JSON
            string data = SerializeDataGridView();

            // Send the serialized data to the server
            byte[] buffer = Encoding.ASCII.GetBytes(data);
            clientSocket.Send(buffer);
        }

        private string SerializeDataGridView()
        {
            // Create a data structure to hold the DataGridView data
            var dataGridData = new
            {
                ColumnCount = dataGridView1.ColumnCount,
                RowCount = dataGridView1.RowCount,
                Headers = dataGridView1.Columns.Cast<DataGridViewColumn>().Select(c => c.HeaderText).ToArray(),
                Values = dataGridView1.Rows.Cast<DataGridViewRow>()
                    .Select(r => r.Cells.Cast<DataGridViewCell>().Select(c => c.Value).ToArray())
                    .ToArray()
            };

            // Serialize the data to JSON
            string jsonData = JsonConvert.SerializeObject(dataGridData);

            return jsonData;
        }


    }
}
