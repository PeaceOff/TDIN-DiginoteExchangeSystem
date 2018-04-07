using System;
using Shared;
using System.Collections.Generic;

namespace Server
{
    public class DiginoteSystem : MarshalByRefObject, IDiginoteSystem
    {
        public event UpdateQuoteEvent UpdateQuote;

        // TODO mover isto para a db (maybe?)
        List<PurchaseOrder> mPurchaseOrders = new List<PurchaseOrder>();
        List<SellOrder> mSellOrders = new List<SellOrder>();

        private static double QUOTE = 1.00;

        public DiginoteSystem()
        {
            //TODO Verificar
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

        public bool PurchaseOrders(string username, int quantity)
        {
            if (ServerDB.InsertPurchaseOrder(username, quantity).Count == quantity)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool SellOrders(string username, int quantity)
        {
            if(ServerDB.InsertSellingOrder(username, quantity).Count == quantity)
            {
                return true;
            } else
            {
                return false;
            }
        }

        public bool SetPurchasePrice(int price)
        {
            double quote = ServerDB.GetQuote();

            if (price >= quote)  {
                ServerDB.UpdateQuote(price);
                return true;
            } else {
                return false;
            }                         
        }

        public bool SetSellPrice(int price)
        {
            double quote = ServerDB.GetQuote();

            if (price <= quote)
            {
                ServerDB.UpdateQuote(price);
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

        List<SellOrder> IDiginoteSystem.GetPendingSellOrders(string username)
        {
            return ServerDB.GetSellingOrders(username);
        }

        List<PurchaseOrder> IDiginoteSystem.GetPendingPurchaseOrders(string username)
        {
            return ServerDB.GetPurchaseOrders(username);
        }

        List<Transaction> IDiginoteSystem.GetTransactions(string username)
        {
            //TODO descomentar quando houver commit desta função
            //return ServerDB.GetTransactions(username);
            return new List<Transaction>();
        }

        List<Transaction> IDiginoteSystem.GetRecentTransactions()
        {
            //TODO descomentar quando houver commit desta função
            //return ServerDB.GetRecentTransactions(username);
            return new List<Transaction>();
        }


    }
}