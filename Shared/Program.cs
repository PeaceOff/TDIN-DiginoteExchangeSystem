using System;
using System.Collections.Generic;

namespace Shared
{
    // Delegate for the Update Quote event
    public delegate void UpdateQuoteEvent(double q);

    // Shared interface for the diginote system (for both client and server)
    public interface IDiginoteSystem
    {
        event UpdateQuoteEvent UpdateQuote;

        string Register(string username, string nickname, string password);
        string Login(string username, string password);

        double GetCurrentQuote(string username);
        bool SetPurchasePrice(int price);
        bool SetSellPrice(int price);

        bool PurchaseOrders(String username, int quantity);
        bool SellOrders(String username, int quantity);        

        List<SellOrder> GetPendingSellOrders(String username);
        List<PurchaseOrder> GetPendingPurchaseOrders(String username);
        List<Diginote> GetDiginotes(String username);
        List<Transaction> GetTransactions(String username);
        List<Transaction> GetRecentTransactions();
    }

    // Event Repeater to respect the compiler rules for the server
    public class EventRepeater : MarshalByRefObject
    {
        public event UpdateQuoteEvent UpdateQuote;

        public void FireUpdateQuoteEvent(double q)
        {
            UpdateQuote(q);
        }

        // Infinite Lease Time
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    [Serializable]
    public class Order
    {
        int quantity;
        DateTime timestamp;
        DateTime suspension;

        public Order(int quantity, DateTime timestamp, DateTime suspension)
        {
            this.quantity = quantity;
            this.timestamp = timestamp;
            this.suspension = suspension;
        }

        public Order() {}

        public int Quantity { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime Suspension { get; set; }
    }

    [Serializable]
    public class PurchaseOrder : Order
    {
        public PurchaseOrder(int quantity, DateTime timestamp, DateTime suspension) : base(quantity, timestamp, suspension) {}

        public PurchaseOrder() : base() {}
    }

    [Serializable]
    public class SellOrder : Order
    {
        public SellOrder(int quantity, DateTime timestamp, DateTime suspension) : base(quantity, timestamp, suspension) {}

        public SellOrder() : base() {}
    }

    [Serializable]
    public class Transaction
    {
        String oldOwner;
        String newOwner;
        int quantity;
        DateTime timestamp;
        double quote;

        public Transaction(String oldOwner, String newOwner, int quantity, DateTime timestamp, double quote)
        {
            this.oldOwner = oldOwner;
            this.newOwner = newOwner;
            this.quantity = quantity;
            this.timestamp = timestamp;
            this.quote = quote;
        }

        public Transaction() {}

        public String OldOwner { get; set; }

        public String NewOwner { get; set; }

        public int Quantity { get; set; }

        public DateTime Timestamp { get; set; }

        public double Quote { get; set; }

        public override string ToString()
        {
            return oldOwner +" sold " + quantity + " diginotes to " +oldOwner;
        }
    }

    [Serializable]
    public class Diginote
    {
        private long serialNumber;

        public Diginote(long serialNumber)
        {
            this.serialNumber = serialNumber;
        }

        public long SerialNumber { get; set; }
    }
}