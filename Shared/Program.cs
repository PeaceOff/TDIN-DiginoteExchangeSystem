using System;

namespace Shared
{
    public delegate void TestHandler(string arg1);

    public interface IDiginoteSystem
    {
        event TestHandler TestEvent;

        string ReturnHello();

        string Register(string username, string password);

        bool Login(string username, string password);
    }

    public class EventRepeater : MarshalByRefObject
    {
        public event TestHandler TestEvent;

        public void FireTestRepeaterEvent(string arg1)
        {
            TestEvent(arg1);
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}