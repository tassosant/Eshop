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
                    if(user.Password == this.PasswordTextBox.Text) {
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
