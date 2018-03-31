using System;

namespace Shared
{
    public delegate void TestHandler(string arg1);

    public interface IDiginoteSystem
    {
        event TestHandler TestEvent;
        string ReturnHello();
    }

    public class EventRepeater : MarshalByRefObject
    {
        public event TestHandler TestRepeaterEvent;

        public void FireTestRepeaterEvent(string arg1)
        {
            TestRepeaterEvent(arg1);
        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
