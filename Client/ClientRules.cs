using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<Transaction> mTransactions = new List<Transaction>();
        private bool isLoggedIn = false;

        // TODO emit purchasing order
        // TODO AT ANY TIME -> increase purchase order price
        // TODO AT ANY TIME -> decrease selling order price
        // TODO AT ANY TIME -> cancel an order
        // TODO Implement events for logging
        // TODO implementar botao para cancelar sell
        // TODO implementar botao para cancelar purchase

        public ClientRules(ClientForm cf)
        {
            clientForm = cf;
            RemotingConfiguration.Configure("Client.exe.config", false);
            diginoteSystem = (IDiginoteSystem)GetRemote.New(typeof(IDiginoteSystem));

            repeater.UpdateQuote += UpdateQuoteHandler;
            repeater.NewTransaction += NewTransactionHandler;
            try
            {
                diginoteSystem.UpdateQuote += repeater.FireUpdateQuoteEvent;
                diginoteSystem.NewTransaction += repeater.FireNewTransactionEvent;
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }

        // Destructor
        ~ClientRules() {

            diginoteSystem.UpdateQuote -= repeater.FireUpdateQuoteEvent;
            diginoteSystem.NewTransaction -= repeater.FireNewTransactionEvent;
            repeater.UpdateQuote -= UpdateQuoteHandler;
            repeater.NewTransaction -= NewTransactionHandler;

        }

        #region UI Functions

        public string Register(string username, string nickname, string password)
        {
            return diginoteSystem.Register(username, nickname, password);
        }

        public string Login(string uname, string pword)
        {
            string result = diginoteSystem.Login(uname, pword);
            username = result;

            if (username != null) {

                isLoggedIn = true;

                mSellOrders = diginoteSystem.GetPendingSellOrders(username);
                clientForm.UpdateSellOrders(mSellOrders);

                mPurchaseOrders = diginoteSystem.GetPendingPurchaseOrders(username);
                clientForm.UpdatePurchaseOrders(mPurchaseOrders);

                int sellTotal = 0;
                foreach (var order in mSellOrders)
                {
                    sellTotal += order.quantity;
                }

                mWallet = diginoteSystem.GetDiginotes(username);
                clientForm.UpdateDiginotes((mWallet.Count - sellTotal).ToString() + " (" + sellTotal.ToString() + ")");

                // TODO Utilizar valores na interface
                mTransactions = diginoteSystem.GetTransactions(username);
            }

            return username;
        }

        public void Logout() {

            isLoggedIn = false;
            username = null;
            mWallet = new List<Diginote>();
            mSellOrders = new List<SellOrder>();
            mPurchaseOrders = new List<PurchaseOrder>();
            mTransactions = new List<Transaction>();

        }

        public void CreateSellingOrder(int amount)
        {
            int pending = 0;
            
            foreach (var order in mSellOrders)
            {
                pending += order.quantity;
            }
            
            if (amount > (mWallet.Count - pending))
            {
                clientForm.UpdateStatus("You don't have that many diginotes!", false);
                return;
            }

            if (mPurchaseOrders.Count > 0)
            {
                clientForm.UpdateStatus("You can't sell while having pending purchases.", false);
                return;
            }

            List<int> serials = diginoteSystem.SellOrders(username, amount);

            if (serials.Count == 0)
            {
                // TODO Pedir se quer baixar preço
                clientForm.UpdateStatus("No diginote was sold. Request Pending.", false);
                pending += amount;
                AddSellOrder();
            }
            else if (serials.Count == amount)
            {
                clientForm.UpdateStatus("All " + amount + " diginote(s) sold!", true);
            }
            else
            {
                // TODO Pedir se quer baixar preço
                string msg = serials.Count + " diginote(s) sold.\n" + "Remaining " + (amount - serials.Count) + " pending.";
                clientForm.UpdateStatus(msg, true);
                pending += amount - serials.Count;
                AddSellOrder();
            }

            // Remove traded diginotes from wallet
            mWallet.Where(d => !serials.Contains(d.serialNumber));
            clientForm.UpdateDiginotes(mWallet.Count - pending + " (" + pending + ")");
        }

        public void CreatePurchaseOrder(int amount) {

            if (mSellOrders.Count > 0)
            {
                clientForm.UpdateStatus("You can't buy while having pending sell orders.", false);
                return;
            }

            // TODO Lógica das purchases
        }

        private void AddSellOrder()
        {
            mSellOrders = diginoteSystem.GetPendingSellOrders(username);
            clientForm.UpdateSellOrders(mSellOrders);
        }

        public double GetCurrentQuote() {

            if (username != null) {
                return diginoteSystem.GetCurrentQuote(username);
            }

            return 0.0;
        }

        #endregion

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
            if (!isLoggedIn) {
                return;
            }
            clientForm.UpdateQuote(q);
        }

        public void NewTransactionHandler(Transaction t)
        {
            if (!isLoggedIn)
            {
                return;
            }
            // TODO Acabar
        }
    }  
}