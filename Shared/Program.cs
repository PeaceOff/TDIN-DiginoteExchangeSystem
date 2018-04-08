using System;
using System.Collections.Generic;

namespace Shared
{
    // Delegate for the Update Quote event
    public delegate void UpdateQuoteEvent(double q);
    public delegate void NewTransactionEvent(Transaction t);

    // Shared interface for the diginote system (for both client and server)
    public interface IDiginoteSystem
    {
        event UpdateQuoteEvent UpdateQuote;
        event NewTransactionEvent NewTransaction; 

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
        public event NewTransactionEvent NewTransaction;

        public void FireUpdateQuoteEvent(double q)
        {
            UpdateQuote(q);
        }

        public void FireNewTransactionEvent(Transaction t)
        {
            NewTransaction(t);
        }

        // Infinite Lease Time
        public override object InitializeLifetimeService()
        {
            return null;
        }
    }

    // Order object
    [Serializable]
    public class Order
    {
        int id;
        int quantity;
        DateTime timestamp;
        DateTime suspension;

        public Order(int id, int quantity, DateTime timestamp, DateTime suspension)
        {
            this.id = id;
            this.quantity = quantity;
            this.timestamp = timestamp;
            this.suspension = suspension;
        }

        public Order() {}

        public int Id { get; set; }

        public int Quantity { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime Suspension { get; set; }
    }

    // Purchase order object
    [Serializable]
    public class PurchaseOrder : Order
    {
        public PurchaseOrder(int id, int quantity, DateTime timestamp, DateTime suspension) : base(id, quantity, timestamp, suspension) {}

        public PurchaseOrder() : base() {}
    }

    // Sell order object
    [Serializable]
    public class SellOrder : Order
    {
        public SellOrder(int id, int quantity, DateTime timestamp, DateTime suspension) : base(id, quantity, timestamp, suspension) {}

        public SellOrder() : base() {}
    }

    // Transaction object
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

    // Diginote represents the currency in the system
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