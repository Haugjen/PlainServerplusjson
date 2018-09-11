using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using ModelLibr;
using Newtonsoft.Json;

namespace JsonServer
{
    internal class Server
    {
        private int PORT;

        public Server(int port)
        {
            this.PORT = port;
        }

        public void Start()
        {
            // Set up to be a Server to listen on a specific port
            // and start the server -- A port can only be used once at each computer
            TcpListener thisServer = new TcpListener(IPAddress.Any, PORT);
            thisServer.Start();

            // To ensure the server can handle more than one client
            while (true)
            {
                // wait for the next client -- if no client the server wait here forever
                TcpClient socket = thisServer.AcceptTcpClient();

                // Handle One client in a seperate thread - i.e. to serve mulitple clients simultaneously
                Task.Run(() =>
                {
                    TcpClient tempSocket = socket;
                    DoClient(socket);
                });
            }

        }

        private void DoClient(TcpClient socket)
        {
            using (StreamReader sr = new StreamReader(socket.GetStream()))
            {
                // Read a line (i.e. a json string) from the network (i.e. socket)
                string jsonLine = sr.ReadLine();

                // Map the json string into an object of the class Car
                // NB! 'add reference' to your modelLib and install the NuGet Package Newtonsoft.json
                Car inCar = JsonConvert.DeserializeObject<Car>(jsonLine);
                
                Console.WriteLine($"Car as json string {jsonLine}\r\nAnd as tostring {inCar.ToString()}");
            }
            socket?.Close();

        }
    }
}