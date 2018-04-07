using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DiginoteExchangeSystem
{
    class Order
    {
        int quantity;
        DateTime timestamp;
        DateTime suspension;

        public Order(int quantity, DateTime timestamp, DateTime suspension)
        {
            this.quantity = quantity;
            this.timestamp = timestamp;
            this.suspension = suspension;
        }

        public Order()
        {

        }

        public int Quantity { get; set; }

        public DateTime Timestamp { get; set; }

        public DateTime Suspension { get; set; }
    }
}
