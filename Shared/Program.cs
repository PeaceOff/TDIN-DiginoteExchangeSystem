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
        void IncreasePurchasePrice(double price);
        void DecreaseSellPrice(double price);

        List<int> PurchaseOrders(String username, int quantity);
        List<int> SellOrders(String username, int quantity);        

        List<SellOrder> GetPendingSellOrders(String username);
        List<PurchaseOrder> GetPendingPurchaseOrders(String username);
        List<Diginote> GetDiginotes(String username);
        List<Transaction> GetTransactions(String username);
        List<Transaction> GetRecentTransactions();

        void DeleteSellOrder(SellOrder order);
        void DeletePurchaseOrder(PurchaseOrder order);
        void UnsuspendOrders(string username);
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
        public int id;
        public int quantity;
        public DateTime timestamp;
        public DateTime suspension;

        public Order(int id, int quantity, DateTime timestamp, DateTime suspension)
        {
            this.id = id;
            this.quantity = quantity;
            this.timestamp = timestamp;
            this.suspension = suspension;
        }

        public Order() {}
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
        public String oldOwner;
        public String newOwner;
        public int quantity;
        public DateTime timestamp;
        public double quote;

        public Transaction(String oldOwner, String newOwner, int quantity, DateTime timestamp, double quote)
        {
            this.oldOwner = oldOwner;
            this.newOwner = newOwner;
            this.quantity = quantity;
            this.timestamp = timestamp;
            this.quote = quote;
        }

        public Transaction() {}

        public override string ToString()
        {
            return oldOwner +" sold " + quantity + " diginotes to " + newOwner;
        }
    }

    // Diginote represents the currency in the system
    [Serializable]
    public class Diginote
    {
        public int serialNumber;

        public Diginote(int serialNumber)
        {
            this.serialNumber = serialNumber;
        }
    }
}