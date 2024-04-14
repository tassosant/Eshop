using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.CashRegister
{
    internal class Cart
    {
        public int UserId { get; set; }
        public Dictionary<int,int> Products { get; set; } //productId,items/product
        public float Price { get; set; }

        
        
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
