using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using Shared;
using System.Windows.Forms;

namespace Client
{

    class ClientRules
    {
        delegate void RedrawQuoteDelegate(double q);
        delegate void ConfirmDialogDelegate(double q);
        delegate void UpdateSellOrderDelegate(List<SellOrder> so);
        delegate void UpdatePurchaseOrderDelegate(List<PurchaseOrder> po);
        delegate void UpdateTransactionsDelegate(List<Transaction> t);
        delegate void UpdateDiginotesDelegate(string s);

        public IDiginoteSystem diginoteSystem = null;
        private EventRepeater repeater = new EventRepeater();

        public String username = null;
        private ClientForm clientForm;
        private List<Diginote> mWallet = new List<Diginote>();
        public List<SellOrder> mSellOrders = new List<SellOrder>();
        public List<PurchaseOrder> mPurchaseOrders = new List<PurchaseOrder>();
        private List<Transaction> mTransactions = new List<Transaction>();
        private List<Transaction> mGlobalTransactions = new List<Transaction>();
        private bool isLoggedIn = false;

        // TODO Implement events for logging

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

                mTransactions = diginoteSystem.GetTransactions(username);
                clientForm.UpdateMyTransactions(mTransactions);

                mGlobalTransactions = diginoteSystem.GetRecentTransactions();
                clientForm.UpdateGlobalTransactions(mGlobalTransactions);
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
            mGlobalTransactions = new List<Transaction>();

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

            bool prompt = false;

            if (serials.Count == 0)
            {
                clientForm.UpdateStatus("No diginote was sold. Request Pending.", false);
                pending += amount;
                AddSellOrder();
                prompt = true;
            }
            else if (serials.Count == amount)
            {
                clientForm.UpdateStatus("All " + amount + " diginote(s) sold!", true);
            }
            else
            {
                string msg = serials.Count + " diginote(s) sold.\n" + "Remaining " + (amount - serials.Count) + " pending.";
                clientForm.UpdateStatus(msg, true);
                pending += amount - serials.Count;
                AddSellOrder();
                prompt = true;
            }

            // Remove traded diginotes from wallet
            mWallet.Where(d => !serials.Contains(d.serialNumber));
            clientForm.UpdateDiginotes(mWallet.Count - pending + " (" + pending + ")");

            if (prompt) { // Não vendeu todas, pedir para baixar preço

                var popup = new PopupForm(GetCurrentQuote(), true);

                if (popup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    diginoteSystem.IncreasePurchasePrice(popup.newValue);
                }

                popup.Dispose();

            }
        }

        public void CancelSellOrder() {

            if (mSellOrders.Count == 0) {
                clientForm.UpdateStatus("No orders to cancel.", false);
                return;
            }

            SellOrder toRemove = mSellOrders.First();

            diginoteSystem.DeleteSellOrder(toRemove);

            mSellOrders.Remove(toRemove);
            
            clientForm.UpdateSellOrders(mSellOrders);
            clientForm.UpdateStatus("Sell order canceled!", true);

            int toSell = 0;
            foreach (var order in mSellOrders)
            {
                toSell += order.quantity;
            }
            clientForm.UpdateDiginotes((mWallet.Count - toSell) + " (" + toSell + ")");

        }

        public void CreatePurchaseOrder(int amount) {

            if (mSellOrders.Count > 0)
            {
                clientForm.UpdateStatus("You can't buy while having pending sell orders.", false);
                return;
            }

            List<int> serials = diginoteSystem.PurchaseOrders(username, amount);

            bool prompt = false;

            // não comprou nenhuma. purchase order nova
            if (serials.Count == 0)
            {
                clientForm.UpdateStatus("No diginote was bought. Pending...", false);
                prompt = true;
            }
            // comprou algumas, mas não todas
            else if (serials.Count < amount)
            {
                clientForm.UpdateStatus(serials.Count + " diginotes were sold. Rest are pending.", true);
                prompt = true;
            }
            // comprou todas
            else
            {
                clientForm.UpdateStatus("All diginotes bought!", true);
            }

            // Atualizar pending purchases
            mPurchaseOrders = diginoteSystem.GetPendingPurchaseOrders(username);
            clientForm.UpdatePurchaseOrders(mPurchaseOrders);

            // Atualizar wallet
            mWallet = diginoteSystem.GetDiginotes(username);
            int pending = 0;
            foreach (var order  in mSellOrders)
            {
                pending += order.quantity;
            }
            clientForm.UpdateDiginotes((mWallet.Count - pending) + " (" + pending +")");

            if (prompt)
            { // Não vendeu todas, pedir para aumentar preço

                var popup = new PopupForm(GetCurrentQuote(), false);

                if (popup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    diginoteSystem.IncreasePurchasePrice(popup.newValue);
                }

                popup.Dispose();

            }

        }

        public void CancelPurchaseOrder()
        {

            if (mPurchaseOrders.Count == 0)
            {
                clientForm.UpdateStatus("No orders to cancel.", false);
                return;
            }

            PurchaseOrder toRemove = mPurchaseOrders.First();

            diginoteSystem.DeletePurchaseOrder(toRemove);

            mPurchaseOrders.Remove(toRemove);

            clientForm.UpdatePurchaseOrders(mPurchaseOrders);
            clientForm.UpdateStatus("Purchase order canceled!", true);

        }

        public void IncreasePurchaseOrderPrice()
        {
            if (mPurchaseOrders.Count == 0)
            {
                clientForm.UpdateStatus("You don't have pending purchase orders.",false);
                return;
            }

            var popup = new PopupForm(GetCurrentQuote(), false);

            if (popup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                diginoteSystem.IncreasePurchasePrice(popup.newValue);
            }

            popup.Dispose();
        }

        public void DecreaseSellOrderPrice()
        {
            if (mSellOrders.Count == 0)
            {
                clientForm.UpdateStatus("You don't have pending sell orders.", false);
                return;
            }

            var popup = new PopupForm(GetCurrentQuote(), true);

            if (popup.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {   
                diginoteSystem.DecreaseSellPrice(popup.newValue);
            }

            popup.Dispose();
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

            RedrawQuoteDelegate rDel = new RedrawQuoteDelegate(clientForm.UpdateQuote);
            clientForm.BeginInvoke(rDel, new object[] { q });

            ConfirmDialogDelegate cDel = new ConfirmDialogDelegate(clientForm.ConfirmDialog);
            clientForm.BeginInvoke(cDel, new object[] { q });

            //clientForm.UpdateQuote(q);
        }

        public void NewTransactionHandler(Transaction t)
        {
            if (!isLoggedIn)
            {
                return;
            }

            if (t.newOwner == username || t.oldOwner == username)
            {
                if (mSellOrders.Count != 0)
                {
                    mSellOrders = diginoteSystem.GetPendingSellOrders(username);
                    UpdateSellOrderDelegate sellDel = new UpdateSellOrderDelegate(clientForm.UpdateSellOrders);
                    clientForm.BeginInvoke(sellDel, new object[] { mSellOrders });
                    //clientForm.UpdateSellOrders(mSellOrders);
                }
                else
                {
                    mPurchaseOrders = diginoteSystem.GetPendingPurchaseOrders(username);
                    UpdatePurchaseOrderDelegate purchaseDel = new UpdatePurchaseOrderDelegate(clientForm.UpdatePurchaseOrders);
                    clientForm.BeginInvoke(purchaseDel, new object[] { mPurchaseOrders });
                    //clientForm.UpdatePurchaseOrders(mPurchaseOrders);
                }

                mTransactions = diginoteSystem.GetTransactions(username);
                UpdateTransactionsDelegate tranDel = new UpdateTransactionsDelegate(clientForm.UpdateMyTransactions);
                clientForm.BeginInvoke(tranDel, new object[] { mTransactions });
                //clientForm.UpdateMyTransactions(mTransactions);

                int sellTotal = 0;
                foreach (var order in mSellOrders)
                {
                    sellTotal += order.quantity;
                }
                string sentence = (mWallet.Count - sellTotal).ToString() + " (" + sellTotal.ToString() + ")";
                mWallet = diginoteSystem.GetDiginotes(username);
                UpdateDiginotesDelegate digiDel = new UpdateDiginotesDelegate(clientForm.UpdateDiginotes);
                clientForm.BeginInvoke(digiDel, new object[] { sentence });
                //clientForm.UpdateDiginotes(sentence);
            }

            mGlobalTransactions.Add(t);
            UpdateTransactionsDelegate transDel = new UpdateTransactionsDelegate(clientForm.UpdateGlobalTransactions);
            clientForm.BeginInvoke(transDel, new object[] { mGlobalTransactions });
            //clientForm.UpdateGlobalTransactions(mGlobalTransactions);
        }
    }  
}