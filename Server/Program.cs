using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Timers;
using static Program;

// Socket Listener acts as a server and listens to the incoming
// messages on the specified port and protocol.
public class Program
{
    
    public static void Main(String[] args)
    {

        //StartServer();
        //Console.WriteLine("Starting server...");
        //Server server = new Server();
        //Thread serverThread = new Thread(() => server.Start());
        //serverThread.Start();

        //Console.WriteLine("Press any key to exit...");
        //Console.ReadKey();
    }



    public class Server
    {
        private const int PORT = 8888;
        private Socket serverSocket;
        //Creating the client and server on separate threads allows them to run concurrently,
        //meaning they can both execute at the same time.If we were to run the server and client sequentially(i.e.one after the other) on the same thread,
        //the server would have to wait for the client to finish before it could continue processing.
        public Server()
        {
            // Get Host IP Address that is used to establish a connection
            // In this case, we get one IP address of localhost that is IP : 127.0.0.1
            // If a host has multiple addresses, you will get a list of addresses
            // Create a Socket that will use Tcp protocol
            serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // A Socket must be associated with an endpoint using the Bind method
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, PORT));
        }
        public void Start()
        {
            serverSocket.Listen(10);
            Console.WriteLine($"Server started on port {PORT}");
            while (true)
            {
                Socket clientSocket = serverSocket.Accept();
                Console.WriteLine($"New client connected: {clientSocket.RemoteEndPoint}");

                Thread clientThread = new Thread(() => HandleClient(clientSocket));
                clientThread.Start();
            }
        }

        private void HandleClient(Socket clientSocket)
        {
            byte[] buffer = new byte[1024];
            StringBuilder message = new StringBuilder();

            while (true)
            {
                // Incoming data from the client.
                int bytesRead = clientSocket.Receive(buffer);
                if (bytesRead == 0)
                {
                    break;
                }

                string data = Encoding.ASCII.GetString(buffer, 0, bytesRead);
                message.Append(data);
                Console.WriteLine($"Received message from {clientSocket.RemoteEndPoint}: {message}");
                clientSocket.Send(Encoding.ASCII.GetBytes("Message received"));
            }

            
            clientSocket.Shutdown(SocketShutdown.Both);
            clientSocket.Close();
        }
    }

}