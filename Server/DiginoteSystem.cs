using System;
using Shared;
using System.Collections.Generic;

namespace Server
{
    public class DiginoteSystem : MarshalByRefObject, IDiginoteSystem
    {
        public event UpdateQuoteEvent UpdateQuote;
        // TODO falta usar
        public event NewTransactionEvent NewTransaction;
        
        private static double QUOTE = 1.00;

        public DiginoteSystem()
        {

            if (!ServerDB.InitQuote(QUOTE)) {
                QUOTE = ServerDB.GetQuote();
            }

            Console.WriteLine("Starting System with quote: " + QUOTE);
            Console.WriteLine("DiginoteSystem constructor called.");
        }

        // Setter for the static value of QUOTE that triggers the event
        private void SetQuote(double value) {
            QUOTE = value;
            ServerDB.UpdateQuote(QUOTE);
            UpdateQuote(QUOTE);
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

        public bool SetPurchasePrice(int price)
        {
            if (price >= QUOTE)  {
                SetQuote(price);
                return true;
            } else {
                return false;
            }                         
        }

        public bool SetSellPrice(int price)
        {

            if (price <= QUOTE)
            {
                SetQuote(price);
                return true;
            }
            else
            {
                return false;
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
            //TODO descomentar quando houver commit desta função
            //return ServerDB.GetRecentTransactions(username);
            return new List<Transaction>();
        }


    }
}