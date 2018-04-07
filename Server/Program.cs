using Server.DiginoteExchangeSystem;
using System;
using System.Collections.Generic;
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

            // Register Users
            ServerDB.Register("uDavid", "David", "pass1");
            ServerDB.Register("uEdu", "Edu", "pass2");
            ServerDB.Register("uEdu", "x", "pass2");
            ServerDB.Register("uEdu", "Edu", "x");

            // Login
            if(ServerDB.Login("uEdu", "pass2") != "Edu")
            {
                Console.WriteLine("Test Failed");
            }

            if (ServerDB.Login("x", "pass2") != null)
            {
                Console.WriteLine("Test Failed");
            }

            if (ServerDB.Login("uEdu", "x") != null)
            {
                Console.WriteLine("Test Failed");
            }

            // Order
            ServerDB.InsertPurchaseOrder("uEdu", 10);
        }
    }
}