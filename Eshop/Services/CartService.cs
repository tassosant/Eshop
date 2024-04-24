using Eshop.DTOs;
using Eshop.Mappers;
using Eshop.Models.Account;
using Eshop.Models.CashRegister;
using Eshop.Models.Store;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    internal class CartService
    {
        CartRepository CartRepository {  get; set; }
        UserRepository UserRepository { get; set; }
        public CartService() { 
            CartRepository = new CartRepository();
            UserRepository = new UserRepository();
        }

        

        public Cart CreateNewCart(UserAbstract user)
        {
            
            Cart cart = new Cart();
            cart.UserId = user.UserId;
            CartRepository.Save(cart);
            return cart;
            
        }

        public CartDTO GetOrCreateCart(int userId)
        {
            UserAbstract user = UserRepository.GetUserById(userId);
            CartMap cartMap = new CartMap();
            Cart cart = CartRepository.GetCartById(user.UserId);
            if(cart == null)
            {
                cart = CreateNewCart(user);
            }
            CartDTO cartDTO = new CartDTO();
            cartDTO = cartMap.CartToCartDTO(cart, user);
            return cartDTO;
        }

        public CartDTO AddProductToCart(int userId, ProductDTO productDTO, int items)
        {
            CartDTO cartDTO = GetOrCreateCart(userId);
            ProductMap productMap = new ProductMap();
            Product product = productMap.MapProductDTOToProduct(productDTO);
            if(cartDTO.Products==null)
            {
                cartDTO.Products = new Dictionary<Product, int>();
            }
            if (cartDTO.Products[product] == null)
            {
                cartDTO.Products.Add(product, items);
            }
            else
            {
                cartDTO.Products[product] = items;
            }
            return cartDTO;
        }

    }
}
