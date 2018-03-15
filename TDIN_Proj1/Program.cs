using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Remoting;

namespace TDIN_Proj1
{
    class Program
    {
        static void Main(string[] args)
        {
            RemotingConfiguration.Configure("../../Server.exe.config", false);
        }
    }
}
