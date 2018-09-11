using System;
using System.IO;
using System.Net.Sockets;
using ModelLibr;
using Newtonsoft.Json;

namespace JsonClient
{
    internal class ClientWorker
    {
        private int serverPort;

        public ClientWorker(int serverPort)
        {
            this.serverPort = serverPort;
        }

        public void Start()
        {
            Car car = new Car("Tesla", "green", "JsonCar4");

            using (TcpClient socket = new TcpClient("localhost", serverPort))
                //using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                String jsonStr = JsonConvert.SerializeObject(car);
                sw.WriteLine(jsonStr);
                sw.Flush();
            }

        }
    }
}