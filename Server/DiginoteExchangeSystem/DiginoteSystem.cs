using System;
using Shared;
using Server.DiginoteExchangeSystem;
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

        // TODO delete me
        public string ReturnHello()
        {
            Console.WriteLine("ReturnHello() called");
            SetQuote(1.23);
            return "Hello Client from Server";
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

        public bool Login(string username, string password)
        {
            return ServerDB.Login(username, password);
        }

        // Infinite Lease time
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}