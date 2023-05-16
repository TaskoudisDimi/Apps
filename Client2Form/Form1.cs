using System.Net.Sockets;
using System.Net;
using System.Text;

namespace Client2Form
{
    public partial class Form1 : Form
    {
        private Socket clientSocket;
        public Form1()
        {
            InitializeComponent();
            SqlConnect loaddata = new SqlConnect();
            loaddata.retrieveData("Select * From ProductTbl");
            dataGridView1.DataSource = loaddata.table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            clientSocket.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8888));
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
    }
}