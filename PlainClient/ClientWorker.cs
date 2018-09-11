using System.ComponentModel;
using System.IO;
using System.Net.Sockets;
using ModelLibr;

namespace PlainClient
{
    internal class ClientWorker
    {
        private readonly int serverPort;

        public ClientWorker(int serverPort)
        {
            this.serverPort = serverPort;
        }

        public void Start()
        {
            Car car = new Car("Tesla", "red", "EL23400");
            
            using (TcpClient socket = new TcpClient("localhost", serverPort))
            //using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                sw.WriteLine(car.ToString());
                sw.Flush();
            }
            
        }
    }
}