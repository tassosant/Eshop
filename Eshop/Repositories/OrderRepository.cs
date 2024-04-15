using Eshop.MockDB;
using Eshop.Models.CashRegister;
using Eshop.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Repositories
{
    internal class OrderRepository
    {
        List<Order> Orders { get; set; }
        JSONParser Parser { get; set; }

        public OrderRepository()
        {
            Parser = new JSONParser();
            Orders = GetAllOrders();
        }

        public List<Order> GetAllOrders()
        {
            Parser.ParseOrdersFileToOrders();
            return Parser.Orders;
        }

        public Order GetOrderById(int id)
        {
            try
            {
                return Orders.First(order => order.OrderId == id);
            }
            catch (InvalidOperationException ex)
            {
                return null;
            }
        }

        public void DeleteOrderById(int id)
        {
            int index = Orders.FindIndex(order => order.OrderId == id);
            Orders.RemoveAt(index);
            Parser.OverwriteOrdersJSON(Orders);
        }

        public void UpdateOrder(Order order)
        {
            int id = order.OrderId;
            int index = Orders.FindIndex(order => order.OrderId == id);
            Orders[index] = order;
            Parser.OverwriteOrdersJSON(Orders);
        }

        public void AddOrder(Order order)
        {
            Orders.Add(order);
            Parser.OverwriteOrdersJSON(Orders);
        }

        public void Save(Order order)
        {
            if(GetOrderById(order.OrderId) != null)
            {
                UpdateOrder(order);
            }
            else
            {
                AddOrder(order);
            }
        }
    }
}
