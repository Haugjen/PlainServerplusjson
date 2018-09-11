using System;

namespace XmlClient
{
    class Program
    {
        private const int ServerPort = 20001;

        static void Main(string[] args)
        {
            Console.WriteLine("Client - xml");
            ClientWorker client = new ClientWorker(ServerPort);
            client.Start();


            Console.ReadLine();
        }
    }
}
