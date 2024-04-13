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
        private int _userId;
        private Dictionary<int,int> _products; //productId,items/product
        private float _price;

        public int userId { get { return _userId; } set { _userId = value; } }
        public Dictionary<int, int> Products { get { return _products; } set { _products = value; } }
        public float price { get { return _price;} set { _price = value; } }
        
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
