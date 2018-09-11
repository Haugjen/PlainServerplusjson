using System;

namespace JsonServer
{
    class Program
    {
        private const int PORT = 10002;
        static void Main(string[] args)
        {
            Console.WriteLine("Server - json");
            Server server = new Server(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}
