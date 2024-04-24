using Eshop.Models.Account;
using Eshop.Models.CashRegister;
using Eshop.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.DTOs
{
    internal class CartDTO
    {
        public UserAbstract User { get; set; }

        public Cart Cart { get; set; }
        public Dictionary<Product, int> Products { get; set; } //productId,items/product


    }
}
