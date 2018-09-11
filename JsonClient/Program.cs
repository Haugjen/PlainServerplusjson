using System;

namespace JsonClient
{
    class Program
    {
        // the port number to the server 
        // my own port number are assigned randomly by the underlaying system
        private const int ServerPort = 10002;

        static void Main(string[] args)
        {
            Console.WriteLine("Client - json");
            ClientWorker client = new ClientWorker(ServerPort);
            client.Start();


            // just wait so I can read the terminal window
            Console.ReadLine();
        }
    }
}
