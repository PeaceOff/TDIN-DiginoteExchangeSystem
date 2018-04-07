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
            //TODO descomentar quando o edu fizer a alteração para retornar bool
            //return ServerDB.InsertPurchaseOrder(username, quantity);
            return true;
        }

        public bool SellOrders(string username, int quantity)
        {
            //TODO descomentar quando o edu fizer a alteração para retornar bool
            //return ServerDB.InsertSellingOrder(username, quantity);
            return true;
        }

        public bool SetPrice(int price)
        {
            double quote = ServerDB.GetQuote();

            //TODO ver a cena do tipo da order
            if (price >= quote)  {
                ServerDB.UpdateQuote(price);
                return true;
            } else {
                return false;
            }                         
        }

        public int GetDiginotes(string username)
        {
            throw new NotImplementedException();
        }

        List<SellOrder> IDiginoteSystem.GetPendingSellOrders(string username)
        {
            throw new NotImplementedException();
        }

        List<PurchaseOrder> IDiginoteSystem.GetPendingPurchaseOrders(string username)
        {
            throw new NotImplementedException();
        }

        List<Transaction> IDiginoteSystem.GetTransactions(string username)
        {
            throw new NotImplementedException();
        }

        List<Transaction> IDiginoteSystem.GetRecentTransactions(string username)
        {
            throw new NotImplementedException();
        }
    }
}