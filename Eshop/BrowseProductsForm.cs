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
    public partial class BrowseProductsForm : Form
    {
        ArrayList cart = new ArrayList();
        int userID;
        ArrayList products = new ArrayList();

        public BrowseProductsForm(int userID, ArrayList cart)
        {
            InitializeComponent();
            this.cart = cart;
            this.userID = userID;
            products.Add("product1");
            products.Add("product2");
            products.Add("product3");
            //ShowProducts(products);

        }

        private void ShowProducts(ArrayList products)
        {
            this.SuspendLayout();
            foreach (var item in products)
            {
                Button button = new Button();
                button.Text = item.ToString();
            }
            this.ResumeLayout();
        }

        private void BrowseProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        { // add teapot to cart
          // add product to cart
            int productID = 0;
            String productName = "product 1";
            cart.Add(productID);
            MessageBox.Show(productName + " is added in your cart");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // view teapot
            ProductForm productForm = new ProductForm(userID, cart);
            productForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CartForm cartform = new CartForm(cart);
            cartform.ShowDialog();
        }
    }
}
