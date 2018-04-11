using System;
using Shared;
using System.Collections.Generic;

namespace Server
{
    public class DiginoteSystem : MarshalByRefObject, IDiginoteSystem
    {
        public event UpdateQuoteEvent UpdateQuote;
        public event NewTransactionEvent NewTransaction;
        
        private static double QUOTE = 1.00;

        public DiginoteSystem()
        {

            if (!ServerDB.InitQuote(QUOTE))
            {
                QUOTE = ServerDB.GetQuote();
            }

            ServerDB.NewDBTransaction += HandleNewDBTransactionHandler;

            Console.WriteLine("Starting System with quote: " + QUOTE);
            Console.WriteLine("DiginoteSystem constructor called.");
        }

        ~DiginoteSystem()
        {
            ServerDB.NewDBTransaction -= HandleNewDBTransactionHandler;
        }

        // Setter for the static value of QUOTE that triggers the event
        private void SetQuote(double value) {
            QUOTE = value;
            ServerDB.UpdateQuote(QUOTE);
            UpdateQuote.Invoke(QUOTE);
        }

        public string Register(string username, string nickname, string password)
        {
            return ServerDB.Register(username, nickname, password);
        }

        public double GetCurrentQuote(string username) {

            if (ServerDB.UsernameExists(username))
                return QUOTE;

            return 0.0;
        }

        public string Login(string username, string password)
        {
            return ServerDB.Login(username, password);
        }

        // Infinite Lease time
        public override object InitializeLifetimeService()
        {
            return null;
        }

        public List<int> PurchaseOrders(string username, int quantity)
        {
            return ServerDB.InsertPurchaseOrder(username, quantity);
        }

        public List<int> SellOrders(string username, int quantity)
        {
            return ServerDB.InsertSellingOrder(username, quantity);
        }

        public void IncreasePurchasePrice(double price)
        {
            if (price >= QUOTE)  {
                SetQuote(price);
            }                        
        }

        public void DecreaseSellPrice(double price)
        {
            if (price <= QUOTE)
            {
                SetQuote(price);
            }
        }

        public List<Diginote> GetDiginotes(string username)
        {
            return ServerDB.GetDiginotes(username);
        }

        public List<SellOrder> GetPendingSellOrders(string username)
        {
            return ServerDB.GetSellingOrders(username);
        }

        public List<PurchaseOrder> GetPendingPurchaseOrders(string username)
        {
            return ServerDB.GetPurchaseOrders(username);
        }

        public List<Transaction> GetTransactions(string username)
        {
            return ServerDB.GetTransactions(username);
        }

        public List<Transaction> GetRecentTransactions()
        {
            return ServerDB.GetTransactions(25);
        }

        public void DeleteSellOrder(SellOrder order) {

            ServerDB.DeleteSellingOrder(order);

        }

        public void DeletePurchaseOrder(PurchaseOrder order) {

            ServerDB.DeletePurchaseOrder(order);
        }

        public void UnsuspendOrders(string username)
        {
            ServerDB.UnsuspendOrders(username);
        }

        // Handlers

        public void HandleNewDBTransactionHandler(Transaction t)
        {
            NewTransaction.Invoke(t);
        }

    }
}