using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class DiginoteSystem : MarshalByRefObject, IDiginoteSystem
    {
        public DiginoteSystem() {
            Console.WriteLine("DiginoteSystem constructor called.");
        }

        public string ReturnHello()
        {
            Console.WriteLine("ReturnHello() called");
            return "Hello";
        }
    }
}