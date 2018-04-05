using System;
using System.Runtime.Remoting;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Tests();

            RemotingConfiguration.Configure("Server.exe.config", false);
            Console.WriteLine("Server is running. Press ENTER to exit...");
            Console.Read();
        }

        static void Tests()
        {
            // Initialize the quote
            ServerDB.InitQuote(10);

            // Update Quote
            ServerDB.UpdateQuote(5);

            if(ServerDB.GetQuote() != 5)
            {
                Console.WriteLine("Test Failed");
            }

            ServerDB.UpdateQuote(10);

            if (ServerDB.GetQuote() != 10)
            {
                Console.WriteLine("Test Failed");
            }
        }
    }
}