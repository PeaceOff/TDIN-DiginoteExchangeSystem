using System;

namespace Shared
{
    // Delegate for the Update Quote event
    public delegate void UpdateQuoteEvent(double q);

    // Shared interface for the diginote system (for both client and server)
    public interface IDiginoteSystem
    {
        event UpdateQuoteEvent UpdateQuote;

        string ReturnHello();

        string Register(string username, string nickname, string password);

        string Login(string username, string password);

        double GetCurrentQuote(string username);
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
}