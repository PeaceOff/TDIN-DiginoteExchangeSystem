using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using TDIN_Proj1;

namespace Client
{
    class ClientRules
    {

        public ClientRules()
        {
            // RemotingConfiguration.Configure("Client.exe.config", false);

            IDiginoteSystem system = (IDiginoteSystem)RemotingServices.Connect(typeof(IDiginoteSystem), "tpc://localhost:999/server/diginoteEndpoint");
        }

    }
}
