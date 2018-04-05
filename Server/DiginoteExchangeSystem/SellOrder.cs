using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.DiginoteExchangeSystem
{
    class SellOrder : Order
    {
        public SellOrder(String username, int quantity) : base(username, quantity)
        {
        }

        public SellOrder() : base()
        {

        }


        public bool SetPrice(double price)
        {
            double quote = ServerDB.GetQuote();

            if (price <= quote)
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
