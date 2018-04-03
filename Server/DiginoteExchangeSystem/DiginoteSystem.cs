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
            double q = ServerDB.GetQuote();

            if (q == 0.0)
            {
                ServerDB.InitQuote(QUOTE);
            }
            else {
                QUOTE = q;
                UpdateQuote(QUOTE);
            }

            Console.WriteLine("DiginoteSystem constructor called.");
        }

        // Setter for the static value of QUOTE that triggers the event
        private void SetQuote(double value) {
            QUOTE = value;
            UpdateQuote(QUOTE);
        }

        // TODO delete me
        public string ReturnHello()
        {
            Console.WriteLine("ReturnHello() called");
            SetQuote(1.23);
            return "Hello Client from Server";
        }

        public string Register(string username, string password)
        {
            return ServerDB.Register(username, password);
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