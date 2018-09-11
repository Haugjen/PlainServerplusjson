using System;

namespace ExtJsonServer
{
    class Program
    {
        private const int PORT = 20000;
        static void Main(string[] args)
        {
            Console.WriteLine("Server - json extented");
            Server server = new Server(PORT);
            server.Start();

            Console.ReadLine();
        }
    }
}
