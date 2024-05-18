using Eshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop.Forms
{
    public partial class WelcomeForm : Form
    {
        UserService userService;
        CartService cartService;
        public WelcomeForm()
        {
            InitializeComponent();
            userService = new UserService();
            cartService = new CartService();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.ShowDialog();
            this.Dispose();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.ShowDialog();
            this.Dispose();
        }

        private void GuestButton_Click(object sender, EventArgs e)
        {
            userService.CreateGuest();
            int id = userService.GetGuestId();
            cartService.DeleteCart(id);
            Form1 form = new Form1();
            form.ShowDialog();
            this.Dispose();
        }
    }
}
