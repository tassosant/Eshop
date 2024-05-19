using Eshop.Models.Account;
using Eshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop.Forms
{
    public partial class RegisterForm : Form

    {
        List<Label> errorLabels;
        List<TextBox> fields;
        RegisterFormService service;
        public RegisterForm()
        {
            InitializeComponent();
            InitProperties();
        }

        private void InitProperties()
        {            
            this.service = new RegisterFormService();
            CollectErrorLabels();
            CollectFields();
        }

        private void CollectErrorLabels()
        {
            this.errorLabels = new List<Label>();
            this.errorLabels.Add(this.ErrorUsernameLabel);
            this.errorLabels.Add(this.ErrorPasswordLabel);
            this.errorLabels.Add(this.ErrorConfirmPasswordLabel);
            this.errorLabels.Add(this.ErrorEmailLabel);
        }

        private void CollectFields()
        {
            this.fields = new List<TextBox>();
            this.fields.Add(this.UsernameTextBox);
            this.fields.Add(this.PasswordTextBox);
            this.fields.Add(this.ConfirmPasswordTextBox);
            this.fields.Add(this.EmailTextBox);
        }

        private void ClearFields()
        {
            foreach (TextBox field in this.fields)
            {
                field.Text = string.Empty;
            }
        }

        private void ClearErrorLabels()
        {
            foreach(Label label in this.errorLabels)
            {
                label.Text = string.Empty;
            }
        }

        

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            if(ValidateFields())
            {
                UserAbstract user = ParseFieldsToNewUser();
                Debug.WriteLine("Form Validated");
                Boolean created = this.service.CreateUser(user);
                if(created)
                {
                    Debug.WriteLine("User registered");
                    ClearErrorLabels();
                    ClearFields();
                    LoginForm loginForm = new LoginForm();
                    loginForm.ShowDialog();
                    this.Dispose();
                    //go to next form
                }
                Debug.WriteLine("User could not register");
            }
            else
            {
                Debug.WriteLine("Not Validated");

            }
        }

        private void ConfirmPasswordTextBox_KeyUp(object sender, KeyEventArgs e)
        {            
            if(this.ConfirmPasswordTextBox.Text != this.PasswordTextBox.Text) {
                this.ErrorConfirmPasswordLabel.ForeColor = Color.Red;
                this.ErrorConfirmPasswordLabel.Text = "Wrong verified pasword";
                return;
            }
            this.ErrorConfirmPasswordLabel.Text = "Ok";
            this.ErrorConfirmPasswordLabel.ForeColor = Color.Green;

        }

        private Boolean ValidateFields()
        {
            
            
            if(!ValidateUsername() || !ValidatePassword() || !ValidateConfirmPassword() || !ValidateEmail())
            {
                return false;
            }
            
            return true;
        }

        private Boolean ValidateUsername()
        {
            if (this.UsernameTextBox.Text.Length == 0)
            {
                this.ErrorUsernameLabel.Text = "Username must not be empty";
                return false;
            }
            if (this.service.IsDuplicateUsername(this.UsernameTextBox.Text))
            {
                this.ErrorUsernameLabel.Text = "Username exists";
                return false;
            }
            
            return true;
        }

        private Boolean ValidatePassword()
        {
            if(this.PasswordTextBox.Text.Length == 0)
            {
                this.ErrorPasswordLabel.Text = "Password must not be empty";
                return false;
            }
            return true;
        }

        private Boolean ValidateConfirmPassword()
        {
            if (this.ConfirmPasswordTextBox.Text.Length == 0)
            {
                this.ErrorConfirmPasswordLabel.ForeColor= Color.Red;
                this.ErrorConfirmPasswordLabel.Text = "Password must not be empty";
                return false;
            }
            return true;
        }

        private Boolean ValidateEmail()
        {
            if(this.EmailTextBox.Text.Length == 0)
            {
                this.ErrorEmailLabel.Text = "Email must not be empty";
                return false;
            }
            return true;
        }

        private UserAbstract ParseFieldsToNewUser()
        {
            UserAbstract user = new User();
            user.Username = this.UsernameTextBox.Text;
            user.Password = this.PasswordTextBox.Text;
            user.Email = this.EmailTextBox.Text;
            return user;
        }


    }
}
