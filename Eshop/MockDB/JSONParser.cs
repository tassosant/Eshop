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

namespace Eshop.MockDB
{
    internal class JSONParser
    {
        public List<Cart> Carts { get; set; }
        
        public JSONParser() {

        }

        public void ParseCartsFileToCarts()
        {
            string path = @"..\..\..\MockDB";
            try
            {
                string json = File.ReadAllText(path+"\\"+"carts.json");
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

    }
}
