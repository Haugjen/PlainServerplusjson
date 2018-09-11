using System;

namespace ExtJsonClient
{
    class Program
    {
        private const int ServerPort = 20000;

        static void Main(string[] args)
        {
            Console.WriteLine("Client - json - extented");
            ClientWorker client = new ClientWorker(ServerPort);
            client.Start();


            Console.ReadLine();
        }
    }
}
