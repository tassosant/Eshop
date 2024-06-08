using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Models.CashRegister
{
    internal class Cart
    {
        public int UserId { get; set; }

        public int CartId { get; set; }
        public int State { get; set; }
        public Dictionary<int, int> Products { get; set; } //productId,items/product




        public void AddToCart()
        {

        }

        public void RemoveFromCart()
        {

        }

        public void UpdateQuantity()
        {

        }

        public void UpdatePrice()
        {

        }

        public void ProceedToChekcout()
        {

        }
    }
}
