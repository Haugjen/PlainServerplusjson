using System;

namespace XmlServer
{
    class Program
    {
        private const int PORT = 20001;
        static void Main(string[] args)
        {
            Console.WriteLine("Server - xml");
            Server server = new Server(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}
