using Eshop.Models.Account;
using Eshop.Models.CashRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.DTOs
{
    internal class OrderDTO
    {
        public int OrderId { get; set; }
        public UserAbstract User { get; set; }
        public Cart Cart { get; set; }

        public int OrderStatus { get; set; }

        public float Price { get; set; }
    }
}
