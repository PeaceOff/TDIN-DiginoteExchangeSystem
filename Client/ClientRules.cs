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
        private ClientForm clientForm;

        public ClientRules(ClientForm cf)
        {
            clientForm = cf;
            RemotingConfiguration.Configure("Client.exe.config", false);
            diginoteSystem = (IDiginoteSystem)GetRemote.New(typeof(IDiginoteSystem));

            repeater.UpdateQuote += UpdateQuoteHandler;
            try
            {
                diginoteSystem.UpdateQuote += repeater.FireUpdateQuoteEvent;
                Console.WriteLine(diginoteSystem.ReturnHello());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }

        // UI Functions

        public string Register(string username, string nickname, string password)
        {
            return diginoteSystem.Register(username, nickname, password);
        }

        public bool Login(string username, string password)
        {
            return diginoteSystem.Login(username, password);
        }

        public double GetCurrentQuote() {

            if (username != null) {
                return diginoteSystem.GetCurrentQuote(username);
            }

            return 0.0;
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

        public void UpdateQuoteHandler(double q)
        {
            clientForm.UpdateQuote(q);
        }
    }  
}