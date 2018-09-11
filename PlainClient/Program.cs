using System;

namespace PlainClient
{
    class Program
    {
        private const int ServerPort = 10001;

        static void Main(string[] args)
        {
            Console.WriteLine("Client");
            ClientWorker client = new ClientWorker(ServerPort);
            client.Start();


            Console.ReadLine();
        }
    }
}
