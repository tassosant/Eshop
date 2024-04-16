namespace Eshop.Forms
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SignInButton = new Button();
            UserNameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            SuspendLayout();
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(289, 271);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(150, 46);
            SignInButton.TabIndex = 0;
            SignInButton.Text = "Sign in";
            SignInButton.UseVisualStyleBackColor = true;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(268, 122);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(200, 39);
            UserNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(268, 197);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(200, 39);
            PasswordTextBox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(136, 129);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(126, 32);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(136, 197);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(116, 32);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(SignInButton);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button SignInButton;
        private TextBox UserNameTextBox;
        private TextBox PasswordTextBox;
        private Label UsernameLabel;
        private Label PasswordLabel;
    }
}