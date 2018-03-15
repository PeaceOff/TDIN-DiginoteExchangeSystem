using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDIN_Proj1
{
    class DiginoteSystem : MarshalByRefObject, IDiginoteSystem
    {
        public string ReturnHello()
        {
            Console.WriteLine("Was called");
            return "Hello";
        }
    }
}