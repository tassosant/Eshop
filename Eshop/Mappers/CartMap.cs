using Eshop.DTOs;
using Eshop.Models.Account;
using Eshop.Models.CashRegister;
using Eshop.Models.Store;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Mappers
{
    internal class CartMap
    {
        /*
         * 
         *  public UserAbstract User { get; set; }
            public Cart Cart { get; set; }
            public Dictionary<Product, int> Products { get; set; } //productId,items/product
            

            public int UserId { get; set; }            
            public int CartId { get; set; }
            public Dictionary<int, int> Products { get; set; } //productId,items/product
         */
        public CartMap() { }
        public Cart CartDTOToCart(CartDTO cartDTO)
        {
            Cart cart = new Cart();
            cart.CartId = cartDTO.Cart.CartId;
            cart.UserId = cartDTO.User.UserId;
            cart.Products = ConvertCartDTOProductsToCartProducts(cartDTO.Products);
            return cart;
        }

        public CartDTO CartToCartDTO(Cart cart, UserAbstract user)
        {
            CartDTO cartDTO = new CartDTO();
            cartDTO.Cart = cart;
            cartDTO.User = user;
            if(cart.Products != null)
            {
                cartDTO.Products = ConvertCartProductsToCartDTOProducts(cart.Products);
            }
            else
            {
                cartDTO.Products = null;
            }
            return cartDTO;
        }


        private Dictionary<int,int> ConvertCartDTOProductsToCartProducts(Dictionary<Product,int> productsDTO)
        {
            Dictionary<int,int> products = new Dictionary<int,int>();
            foreach (var productDTO in productsDTO.Keys)
            {
                
                int items = productsDTO[productDTO];
                if (products.ContainsKey(productDTO.ProductId))
                {
                    products[productDTO.ProductId]+=items;
                }
                else
                {
                    products.Add(productDTO.ProductId, items);
                }
            }
            return products;
        }
        
        private Dictionary<Product,int> ConvertCartProductsToCartDTOProducts(Dictionary<int,int> products)
        {
            ProductRepository productRepository = new ProductRepository();
            Dictionary<Product,int> productsDTO = new Dictionary<Product,int>();
            foreach (var productId in products.Keys)
            {
                Product product = productRepository.GetProductById(productId);
                int items = products[productId];
                productsDTO.Add(product,items);
            }
            return productsDTO;
        }
    }
}
