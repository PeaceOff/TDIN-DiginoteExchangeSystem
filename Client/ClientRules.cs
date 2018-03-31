using System;
using System.Runtime.Remoting;
using Shared;

namespace Client
{
    class ClientRules
    {
        private IDiginoteSystem diginoteSystem;
        private EventRepeater repeater;

        private String username = null;

        public ClientRules()
        {
            RemotingConfiguration.Configure("Client.exe.config", false);
            diginoteSystem = (IDiginoteSystem)GetRemote.New(typeof(IDiginoteSystem));

            repeater = new EventRepeater();
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

        }

        public void SetUsername(string username)
        {

        }

        // Handlers

        public void Handler(string arg1)
        {
            Console.WriteLine("ATENCION!!!! " + arg1);
        }
    }  
}