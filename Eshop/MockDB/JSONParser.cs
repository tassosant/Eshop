using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Eshop.CashRegister;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using Eshop.Store;


namespace Eshop.MockDB
{
    internal class JSONParser
    {
        private string Path = @"..\..\..\MockDB";
        public List<Cart> Carts { get; set; }
        
        public JSONParser() {

        }

        public void ParseCartsFileToCarts()
        {
            
            try
            {
                string json = File.ReadAllText(Path+"\\"+"carts.json");
                Carts = JsonSerializer.Deserialize<List<Cart>>(json);
                Debug.WriteLine("Carts parsed successfully: " + Carts.Count);
            }
            catch (FileNotFoundException ex)
            {
                Debug.WriteLine("The file was not found: " + ex.Message);
            }
            catch (JsonException ex)
            {
                Debug.WriteLine("Error parsing JSON: " + ex.Message);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }

        public void AddToCarts()
        {
            
            Dictionary<int,int> products = new Dictionary<int, int>();
            products.Add(301, 30);

            

            Cart cart = new Cart();
            cart.CartId = 3;
            cart.UserId = 3;
            cart.Products = products;
            Carts.Add(cart);
            var cartsJSON = JsonSerializer.Serialize(Carts);
            File.WriteAllText(Path+"\\"+"carts.json",cartsJSON);

        }

    }
}
