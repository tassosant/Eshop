using Eshop.MockDB;
using Eshop.Models.CashRegister;
using Eshop.Repositories;
using Eshop.Services;
using System.Collections;

namespace Eshop
{
    public partial class Form1 : Form
    {
        
        public int UserID {  get; set; }
        UserService UserService { get; set; }
        public Form1()
        {
            UserService = new UserService();
            UserID = UserService.GetGuestId();
            InitializeComponent();          
            this.navbar1.UserID = this.UserID;
            this.navbar1.CheckForPermissions();
        }

        public Form1(int userID)
        {
            UserService = new UserService();
            this.UserID=userID;
            InitializeComponent();
            this.navbar1.UserID=userID;
            this.navbar1.CheckForPermissions();
        }

        private void viewProducts(object sender, EventArgs e)
        {
            // ProductForm productForm = new ProductForm(userID, cart);
            BrowseProductsForm b = new BrowseProductsForm(UserID);
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
            CartForm cartform = new CartForm(UserID);
            cartform.ShowDialog();
        }
    }
}