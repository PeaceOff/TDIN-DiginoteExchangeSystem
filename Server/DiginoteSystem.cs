using System;
using Shared;

namespace Server
{
    public class DiginoteSystem : MarshalByRefObject, IDiginoteSystem
    {
        public event TestHandler TestEvent;

        public DiginoteSystem()
        {
            Console.WriteLine("DiginoteSystem constructor called.");
        }

        public string ReturnHello()
        {
            Console.WriteLine("ReturnHello() called");
            TestEvent("Hello from the event");
            return "Hello Client from Server";
        }

        public string Register(string username, string password)
        {
            return ServerDB.Register(username, password);
        }

        public bool Login(string username, string password)
        {
            return ServerDB.Login(username, password);
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}