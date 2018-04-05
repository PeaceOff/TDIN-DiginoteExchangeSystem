using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DiginoteExchangeSystem
{
    class PurchaseOrder : Order
    {
        public PurchaseOrder(String username, int quantity) : base(username, quantity)
        {
        }

        public PurchaseOrder() : base()
        {

        }

        public bool SetPrice(double price)
        {
            double quote = ServerDB.GetQuote();

            if (price >= quote)
            {
                ServerDB.UpdateQuote(price);
                return true;
            } else
            {
                return false;
            }
        }
    }
}
