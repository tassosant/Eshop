using Eshop.Models.CashRegister;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop
{
    public partial class ProductForm : Form
    {
        ArrayList cart = new ArrayList();
        int userID;
        public ProductForm(int userID, ArrayList cart)
        {
            InitializeComponent();
            this.cart = cart;
            this.userID = userID;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // add product to cart
            int productID = 0;
            String productName = "product 1";
            cart.Add(productID);
            MessageBox.Show(productName + " is added in your cart");


        }
    }
}
