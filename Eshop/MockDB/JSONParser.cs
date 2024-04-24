using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using System.Collections.Generic;
using System.Collections;
using System.Diagnostics;
using Eshop.Models.Account;
using Eshop.Models.Store;
using Eshop.Models.CashRegister;


namespace Eshop.MockDB
{
    internal class JSONParser
    {
        private string Path = @"..\..\..\MockDB";
        public List<Cart> Carts { get; set; }
        public List<UserAbstract> Users { get; set; }

        public List<Category> Categories { get; set; }  

        public List<Product> Products { get; set; }

        public List<Role> Roles { get; set; }

        public List<Order> Orders { get; set; }

        
        
        public JSONParser() {
            
        }
        //Carts
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

        public void OverwriteCartsJSON(List<Cart> carts)
        {
            var cartsJSON = JsonSerializer.Serialize(carts);
            File.WriteAllText(Path + "\\" + "carts.json", cartsJSON);
        }
        //Users
        public void ParseUsersFileToUsers()
        {
            try
            {
                string json = File.ReadAllText(Path + "\\" + "users.json");
                Users = JsonSerializer.Deserialize<List<UserAbstract>>(json);
                Debug.WriteLine("Users parsed successfully: " + Users.Count);
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

        public void OverwriteUsersJSON(List<UserAbstract> users)
        {
            var JSON = JsonSerializer.Serialize(users);
            File.WriteAllText(Path + "\\" + "users.json", JSON);
        }
        //Categories
        public void ParseCategoriesFileToCategories()
        {
            try
            {
                string json = File.ReadAllText(Path + "\\" + "categories.json");
                Categories = JsonSerializer.Deserialize<List<Category>>(json);
                Debug.WriteLine("Categories parsed successfully: " + Categories.Count);
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

        public void OverwriteCategoriesJSON(List<Category> categories)
        {
            var JSON = JsonSerializer.Serialize(categories);
            File.WriteAllText(Path + "\\" + "categories.json", JSON);
        }

        //Roles
        public void ParseRolesFileToRoles()
        {
            try
            {
                string json = File.ReadAllText(Path + "\\" + "roles.json");
                Roles = JsonSerializer.Deserialize<List<Role>>(json);
                Debug.WriteLine("Roles parsed successfully: " + Roles.Count);
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

        public void OverwriteRolesJSON(List<Role> roles)
        {
            var JSON = JsonSerializer.Serialize(roles);
            File.WriteAllText(Path + "\\" + "roles.json", JSON);
        }

        //Orders
        public void ParseOrdersFileToOrders()
        {
            try
            {
                string json = File.ReadAllText(Path + "\\" + "orders.json");
                Orders = JsonSerializer.Deserialize<List<Order>>(json);
                Debug.WriteLine("Orders parsed successfully: " + Orders.Count);
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

        public void OverwriteOrdersJSON(List<Order> orders)
        {
            var JSON = JsonSerializer.Serialize(orders);
            File.WriteAllText(Path + "\\" + "orders.json", JSON);
        }

        //Products
        public void ParseProductsFileToProducts()
        {
            try
            {
                string json = File.ReadAllText(Path + "\\" + "products.json");
                Products = JsonSerializer.Deserialize<List<Product>>(json);
                Debug.WriteLine("Products parsed successfully: " + Products.Count);
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

        public void OverwriteProductsJSON(List<Product> products)
        {
            var JSON = JsonSerializer.Serialize(products);
            File.WriteAllText(Path + "\\" + "products.json", JSON);
        }
    }
}
