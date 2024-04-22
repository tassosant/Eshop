using Eshop.DTOs;
using Eshop.Models.Account;
using Eshop.Models.CashRegister;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Mappers
{
    internal class OrderMap
    {

        /*
            public int OrderId { get; set; }
            public UserAbstract User { get; set; }
            public Cart Cart { get; set; }
            public int OrderStatus { get; set; }
            public float Price { get; set; }

            
            public int OrderId { get; set; }
            public int UserId { get; set; }
            public int CartId { get; set; }
            public int OrderStatus { get; set; }
            public float Price { get; set; }
         */

        public OrderMap() { }
        public Order OrderDTOToOrder(OrderDTO orderDTO)
        {
            Order order = new Order();
            order.OrderId = orderDTO.OrderId;
            order.UserId = orderDTO.User.UserId;
            order.CartId = orderDTO.Cart.CartId;
            order.OrderStatus = orderDTO.OrderStatus;
            order.Price = orderDTO.Price;
            return order;
        }

        public OrderDTO OrderToOrderDTO(Order order)
        {
            OrderDTO orderDTO = new OrderDTO();
            orderDTO.OrderId = order.OrderId;
            UserAbstract user = ConvertUserIdToUser(order.UserId);
            Cart cart = ConvertCartIdToCart(order.CartId);
            orderDTO.User = user;
            orderDTO.Cart = cart;
            orderDTO.OrderStatus = order.OrderStatus;
            orderDTO.Price = order.Price;
            return orderDTO;
        }

        public OrderDTO OrderToOrderDTO(Order order,UserAbstract user,Cart cart)
        {
            OrderDTO orderDTO = new OrderDTO();
            orderDTO.OrderId = order.OrderId;            
            orderDTO.User = user;
            orderDTO.Cart = cart;
            orderDTO.OrderStatus = order.OrderStatus;
            orderDTO.Price = order.Price;
            return orderDTO;
        }

        private UserAbstract ConvertUserIdToUser(int userId)
        {
            UserRepository userRepository = new UserRepository();            
            UserAbstract user = userRepository.GetUserById(userId);
            return user;
        }

        private Cart ConvertCartIdToCart(int cartId) { 
            CartRepository cartRepository = new CartRepository();
            Cart cart = cartRepository.GetCartById(cartId);
            return cart;
        }
    }
}
