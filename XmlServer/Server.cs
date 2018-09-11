using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;
using System.Xml.Serialization;
using ModelLib;

namespace XmlServer
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
                
                XmlSerializer saleSerializer = new XmlSerializer(typeof(AutoSale));
                AutoSale sale = (AutoSale)saleSerializer.Deserialize(sr);
                
                Console.WriteLine($"AutoSale as tostring {sale.ToString()}");
            }
            socket?.Close();
        }
    }
}