using System;
using System.Collections.Generic;
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
        private List<Diginote> mWallet = new List<Diginote>();
        private List<SellOrder> mSellOrders = new List<SellOrder>();
        private List<PurchaseOrder> mPurchaseOrders = new List<PurchaseOrder>(); 

        // TODO Get user wallet
        // TODO emit selling order
        // TODO emit purchasing order
        // TODO AT ANY TIME -> increase purchase order price
        // TODO AT ANY TIME -> decrease selling order price
        // TODO AT ANY TIME -> cancel an order
        // TODO if selling don't purchase
        // TODO if purchase don't sell
        // TODO Implement events for logging

        public ClientRules(ClientForm cf)
        {
            clientForm = cf;
            RemotingConfiguration.Configure("Client.exe.config", false);
            diginoteSystem = (IDiginoteSystem)GetRemote.New(typeof(IDiginoteSystem));

            repeater.UpdateQuote += UpdateQuoteHandler;
            try
            {
                diginoteSystem.UpdateQuote += repeater.FireUpdateQuoteEvent;
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

        public string Login(string uname, string pword)
        {
            string result = diginoteSystem.Login(uname, pword);
            username = result;

            if (username != null) {
                mWallet = diginoteSystem.GetDiginotes(username);
                clientForm.UpdateDiginotes(mWallet.Count);
            }

            return username;
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