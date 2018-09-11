using System;
using System.IO;
using System.Net.Sockets;
using ModelLib;
using ModelLibr;
using Newtonsoft.Json;

namespace ExtJsonClient
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

            Car car1 = new Car("Tesla", "green", "JsonCar1");
            Car car2 = new Car("Tesla", "blue", "JsonCar2");
            AutoSale sale = new AutoSale("Peters","Roskilde");
            sale.Cars.Add(car1);
            sale.Cars.Add(car2);



            using (TcpClient socket = new TcpClient("localhost", serverPort))
                //using (StreamReader sr = new StreamReader(socket.GetStream()))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                String jsonStr = JsonConvert.SerializeObject(sale);
                sw.WriteLine(jsonStr);
                sw.Flush();
            }
        }
    }
}