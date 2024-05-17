using Eshop.MockDB;
using Eshop.Models.Account;
using Eshop.Models.CashRegister;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Repositories
{
    internal class CartRepository
    {

        List<Cart> Carts { get; set; }   
        JSONParser Parser { get; set; }

        public int guestId = 100;

        public CartRepository() {
            Parser = new JSONParser();
            Carts = GetAllCarts();    
        }

        public List<Cart> GetAllCarts()
        {
            Parser.ParseCartsFileToCarts();
            return Parser.Carts;
        }

        public Cart GetCartById(int id)
        {
            try
            {
                return Carts.First(cart => cart.CartId == id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteCardById(int id)
        {
            int index = Carts.FindIndex(cart => cart.CartId == id);
            if (index == -1)
            {
                return;
            }
            Carts.RemoveAt(index);
            Parser.OverwriteCartsJSON(Carts);
        }

        public void UpdateCart(Cart cart)
        {
            int id = cart.CartId;
            int index = Carts.FindIndex(cart=>cart.CartId == id);
            Carts[index] = cart;
            Parser.OverwriteCartsJSON(Carts);
        }

        public void AddCart(Cart cart)
        {
            List<Cart> carts = GetAllCarts().OrderBy(cart => cart.CartId).ToList();
            if (cart.CartId != guestId)
            {
                cart.CartId = carts.Last().CartId + 1;
            }
            Carts.Add(cart);
            Parser.OverwriteCartsJSON(Carts);
        }

        public void Save(Cart cart)
        {
            int id = cart.CartId;
            
            if(GetCartById(id) != null)
            {
                UpdateCart(cart);
            }
            else
            {
                AddCart(cart);
            }
        }
    }
}
