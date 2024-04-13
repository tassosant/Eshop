using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.CashRegister
{
    internal class Order
    {
        private int _orderId; 
        private int _userId;
        private Cart _cart;

        public int OrderId { get { return _orderId; } set { _orderId = value; } }
        public int UserId { get { return _userId; } set { _userId = value; } }  
        public Cart Cart { get { return _cart; } set { _cart = value; } }

        public void Pay()
        {

        }

        public void Shipping()
        {

        }

        public void Confirm()
        {

        }
    }
}
