using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.CashRegister
{
    internal class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int CartId { get; set; }

        public int OrderStatus { get; set; }

        public float Price { get; set; }        

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
