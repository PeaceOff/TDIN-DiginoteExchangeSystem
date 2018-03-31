using System;
using System.Runtime.Remoting;

namespace Server
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("Server.exe.config", false);
            Console.WriteLine("Server is running. Press ENTER to exit...");
            Console.Read();
        }
    }
}