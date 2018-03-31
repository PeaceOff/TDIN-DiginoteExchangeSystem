using System;
using System.Collections;
using System.Runtime.Remoting;
using Shared;

namespace Client
{
    class ClientRules
    {
        IDiginoteSystem mSystem;
        EventRepeater repeater;

        public ClientRules()
        {
            RemotingConfiguration.Configure("Client.exe.config", false);
            repeater = new EventRepeater();
            repeater.TestEvent += Handler;
            try
            {
                mSystem = (IDiginoteSystem)GetRemote.New(typeof(IDiginoteSystem));
                mSystem.TestEvent += repeater.FireTestRepeaterEvent;
                Console.WriteLine(mSystem.ReturnHello());
            }
            catch (Exception ex)
            {
                Console.WriteLine("ERROR: " + ex.ToString());
            }
        }

        public void Handler(string arg1) {
            Console.WriteLine("ATENCION!!!! " + arg1);
        }
    }

    // Class copied from the Demos to connect to a remote object
    class GetRemote
    {
        private static IDictionary wellKnownTypes;

        public static object New(Type type)
        {
            if (wellKnownTypes == null)
                InitTypeCache();
            WellKnownClientTypeEntry entry = (WellKnownClientTypeEntry)wellKnownTypes[type];
            if (entry == null)
                throw new RemotingException("Type not found!");
            return Activator.GetObject(type, entry.ObjectUrl);
        }

        public static void InitTypeCache()
        {
            Hashtable types = new Hashtable();
            foreach (WellKnownClientTypeEntry entry in RemotingConfiguration.GetRegisteredWellKnownClientTypes())
            {
                if (entry.ObjectType == null)
                    throw new RemotingException("A configured type could not be found!");
                types.Add(entry.ObjectType, entry);
            }
            wellKnownTypes = types;
        }
    }
}
