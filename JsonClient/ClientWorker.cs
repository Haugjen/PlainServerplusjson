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
            // create an object of the Car class
            // NB! I have to 'Add a reference' to the dependencies to my ModelLib
            Car car = new Car("Tesla", "green", "JsonCar4");

            // Create a conenction to the server
            // and wrap the Stream into a more smooth StreamWriter, that can write string-lines 
            using (TcpClient socket = new TcpClient("localhost", serverPort))
            using (StreamWriter sw = new StreamWriter(socket.GetStream()))
            {
                // Serialize my car object
                // NB! I have to install the NuGet package newtonsoft.json 
                String jsonStr = JsonConvert.SerializeObject(car);

                // write the json-string to the socket-stream and flush the buffer
                sw.WriteLine(jsonStr);
                sw.Flush();
            }

        }
    }
}