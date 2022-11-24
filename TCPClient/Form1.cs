using SimpleTCP;
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


namespace TCPClient
{
    public partial class Form1 : Form
    {
        SimpleTcpClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            client = new SimpleTcpClient();
            client.StringEncoder = Encoding.UTF8;
            client.DataReceived += Client_DataReceived;




            // Get the details from the user and store them.  
            Person person = new Person();

            person.Name = "Test1";
            person.Email = "Test1";
            person.Message = "Test1";
            // Send the message  
            //byte[] bytes = sendMessage(System.Text.Encoding.Unicode.GetBytes(person.ToJSON()));

        }

        private static byte[] sendMessage(byte[] messageBytes)
        {
            const int bytesize = 1024 * 1024;
            try // Try connecting and send the message bytes  
            {
                System.Net.Sockets.TcpClient client = new System.Net.Sockets.TcpClient("127.0.0.1", 1234); // Create a new connection  
                NetworkStream stream = client.GetStream();

                stream.Write(messageBytes, 0, messageBytes.Length); // Write the bytes  
                Console.WriteLine("================================");
                Console.WriteLine("=   Connected to the server    =");
                Console.WriteLine("================================");
                Console.WriteLine("Waiting for response...");

                messageBytes = new byte[bytesize]; // Clear the message   

                // Receive the stream of bytes  
                stream.Read(messageBytes, 0, messageBytes.Length);

                // Clean up  
                stream.Dispose();
                client.Close();
            }
            catch (Exception e) // Catch exceptions  
            {
                Console.WriteLine(e.Message);
            }

            return messageBytes; // Return response  
        }



        private void connectButton_Click(object sender, EventArgs e)
        {
            connectButton.Enabled = false;
            System.Net.IPAddress ip = System.Net.IPAddress.Parse(hostTextBox.Text);
            client.Connect(hostTextBox.Text, Convert.ToInt32(portTextBox.Text));
        }
        private void Client_DataReceived(object sender, SimpleTCP.Message e)
        {
            statusTextBox.Invoke((MethodInvoker)delegate ()
            {
                statusTextBox.Text += e.MessageString;
            });
        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            client.WriteLineAndGetReply(messageTextBox.Text, TimeSpan.FromSeconds(3));
        }
    }
}
