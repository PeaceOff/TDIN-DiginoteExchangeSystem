using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DiginoteExchangeSystem
{
    class Order
    {
        String username;
        int quantity;
        DateTime timestamp;
        DateTime suspension;

        public Order(String username, int quantity)
        {
            this.username = username;
            this.quantity = quantity;
            this.timestamp = DateTime.Now;
        }

        public Order()
        {

        }

        public void SetSuspension()
        {
            this.suspension = DateTime.Now;
        }
    }
}
