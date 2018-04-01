using System;
using System.Runtime.Remoting;
using Shared;

namespace Client
{
    class ClientRules
    {
        private IDiginoteSystem diginoteSystem = null;
        private EventRepeater repeater = new EventRepeater();

        private String username = null;

        public ClientRules()
        {
            RemotingConfiguration.Configure("Client.exe.config", false);
            diginoteSystem = (IDiginoteSystem)GetRemote.New(typeof(IDiginoteSystem));

            repeater.TestEvent += Handler;
            try
            {
                diginoteSystem.TestEvent += repeater.FireTestRepeaterEvent;
                Console.WriteLine(diginoteSystem.ReturnHello());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }

        // UI Functions

        public string Register(string username, string password)
        {
            return diginoteSystem.Register(username, password);
        }

        public bool Login(string username, string password)
        {
            return diginoteSystem.Login(username, password);
        }

        // Getters and Setters

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string un)
        {
            username = un;
        }

        // Handlers

        public void Handler(string arg1)
        {
            Console.WriteLine("ATENCION!!!! " + arg1);
        }
    }  
}