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
using Eshop.Account;


namespace Eshop.MockDB
{
    internal class JSONParser
    {
        private string Path = @"..\..\..\MockDB";
        public List<Cart> Carts { get; set; }
        public List<UserAbstract> Users { get; set; }
        
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

        public void OverwriteCartsJSON(List<Cart> carts)
        {
            var cartsJSON = JsonSerializer.Serialize(carts);
            File.WriteAllText(Path + "\\" + "carts.json", cartsJSON);
        }

        public void ParseUsersFileToUsers()
        {
            try
            {
                string json = File.ReadAllText(Path + "\\" + "users.json");
                Users = JsonSerializer.Deserialize<List<UserAbstract>>(json);
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

        public void OverwriteUsersJSON(List<UserAbstract> users)
        {
            var JSON = JsonSerializer.Serialize(users);
            File.WriteAllText(Path + "\\" + "users.json", JSON);
        }

    }
}
