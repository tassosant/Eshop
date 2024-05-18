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

        ProductRepository ProductRepository { get; set; }

        ProductMap ProductMap { get; set; } 
        public CartService() { 
            CartRepository = new CartRepository();
            UserRepository = new UserRepository();
            ProductRepository = new ProductRepository();
            ProductMap = new ProductMap();
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
            if(userId == 0)
            {
                return null;
            }
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
            if (!cartDTO.Products.ContainsKey(product))
            {
                cartDTO.Products.Add(product, items);
            }
            else
            {
                cartDTO.Products[product] = items;
            }
            return cartDTO;
        }
        

        public CartDTO AddProductToCart(int userId,int productId,int items)
        {
            
            Product product = ProductRepository.GetProductById(productId);
            ProductDTO productDTO = ProductMap.MapProductToProductDTO(product, items);
            return AddProductToCart(userId, productDTO, items);
        }

        public void SaveCart(CartDTO cartDTO)
        {
            CartMap cartMap = new CartMap();
            Cart cart = cartMap.CartDTOToCart(cartDTO);
            CartRepository.Save(cart);
        }

        public void DeleteCart(int userId)
        {
            CartRepository.DeleteCardById(userId);
        }

        public double CalculateTotalPrice(int userID)
        {
            if (userID == 0)
            {
                return 0.0;
            }
            CartDTO cartDTO = GetOrCreateCart(userID);
            if (cartDTO == null)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach(Product product in cartDTO.Products.Keys)
            {
                total+= product.Price*cartDTO.Products[product];
            }
            return total;
        }

    }
}
