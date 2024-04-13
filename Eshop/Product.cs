using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop
{
    internal abstract class Product
    {
        private int _productId;
        private int _categoryId;
        private float _price;

        public int ProductId { get { return _productId; } set { _productId = value; } }
        public int CategoryId { get { return _categoryId; } set { _categoryId = value; } }
        public float Price { get { return _price;} set { _price = value; } }

        
    }
}
