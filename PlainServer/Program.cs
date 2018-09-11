using System;

namespace PlainServer
{
    class Program
    {
        private const int PORT = 10001;
        static void Main(string[] args)
        {
            Console.WriteLine("Server");
            Server server = new Server(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}
