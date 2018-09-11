using System;

namespace JsonClient
{
    class Program
    {
        private const int ServerPort = 10002;

        static void Main(string[] args)
        {
            Console.WriteLine("Client - json");
            ClientWorker client = new ClientWorker(ServerPort);
            client.Start();


            Console.ReadLine();
        }
    }
}
