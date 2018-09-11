using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace PlainServer
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
            TcpListener thisServer = new TcpListener(IPAddress.Any, PORT);
            thisServer.Start();

            while (true)
            {
                TcpClient socket = thisServer.AcceptTcpClient();
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
            //using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                string line = sr.ReadLine();
                Console.WriteLine($"Car as string \r\n{line}");
            }
            socket?.Close();
        }
    }
}