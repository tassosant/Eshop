using Eshop.MockDB;
using Eshop.Models.CashRegister;
using Eshop.Repositories;
using System.Collections;

namespace Eshop
{
    public partial class Form1 : Form
    {
        ArrayList cart = new ArrayList();
        int userID = 0;
        public Form1()
        {
            InitializeComponent();
            CartRepository cartRepository = new CartRepository();
            cartRepository.GetCartById(10);


        }

        private void viewProducts(object sender, EventArgs e)
        {
            // ProductForm productForm = new ProductForm(userID, cart);
            BrowseProductsForm b = new BrowseProductsForm(userID, cart);
            b.ShowDialog();
            //productForm.ShowDialog();
            //productForm.Tag = this;
            //productForm.Show(this);
            // Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            CartForm cartform = new CartForm(cart);
            cartform.ShowDialog();
        }
    }
}