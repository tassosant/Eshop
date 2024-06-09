using Eshop.CustomComponents;
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
        CartService CartService { get; set; }
        private CustomComponents.Navbar navbar1;
        public Form1()
        {
            UserService = new UserService();
            CartService = new CartService();
            UserID = UserService.GetGuestId();
            InitializeComponent();  
            
            InitProperties();
            CartService.DeleteCart(UserID);
        }

        public Form1(int userID)
        {
            UserService = new UserService();
            CartService = new CartService();
            this.UserID=userID;
            InitializeComponent();           
            InitProperties();
            CartService.DeleteCart(UserID);
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

        private void LoadNavbar()
        {
            SuspendLayout();
            components = new System.ComponentModel.Container();
            navbar1 = new CustomComponents.Navbar(components);
            // 
            // navbar1
            // 
            navbar1.ImageScalingSize = new Size(32, 32);
            navbar1.Location = new Point(0, 0);
            navbar1.Name = "navbar1";
            navbar1.Size = new Size(1040, 40);
            navbar1.TabIndex = 2;
            navbar1.Text = "navbar1";
            Controls.Add(navbar1);
            MainMenuStrip = navbar1;
            Margin = new Padding(4, 4, 4, 4);
            ResumeLayout(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CartForm cartform = new CartForm(UserID);
            cartform.ShowDialog();
        }

        private void InitProperties()
        {
            LoadNavbar();
            this.navbar1.UserID = this.UserID;
            this.navbar1.CheckForPermissions();
            //this.FormClosing += new FormClosingEventHandler(CloseForm);
        }

        private void CloseForm(object sender, FormClosingEventArgs e)
        {
            CloseFormHandler.HandleClosingForm(sender as Form,e);
        }
        
    }
}