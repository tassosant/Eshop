using Eshop.Models.Account;
using Eshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop.Forms
{
    public partial class LoginForm : Form
    {
        LoginFormService loginFormService;
        public UserAbstract User {  get; set; }
        public LoginForm()
        {
            InitializeComponent();
            InitProperties();
            
        }

        private void InitProperties()
        {
            this.ErrorLoginLabel.Hide();
            this.loginFormService = new LoginFormService();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            if (ValidateUser())
            {
                this.ErrorLoginLabel.Hide();
                Debug.WriteLine("User found");
                Form1 homeUserForm = new Form1(User.UserId);
                homeUserForm.ShowDialog();
                this.Dispose();
            }
            else
            {
                Debug.WriteLine("User did not found");
            }
        }

        private Boolean ValidateUser()
        {
            if (this.loginFormService != null)
            {
                UserAbstract user = this.loginFormService.GetUser(this.UserNameTextBox.Text);
                if (user != null )
                {
                    if(user.Password.Equals(this.PasswordTextBox.Text)) {
                        User = user; 
                        return true;
                    }
                    else
                    {
                        this.ErrorLoginLabel.Show();
                        return false;
                    }
                }
                this.ErrorLoginLabel.Show();
            }
            return false;
        }

        
    }
}
