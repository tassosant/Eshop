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
            ErrorUsernameLabel = new Label();
            ErrorPasswordLabel = new Label();
            ErrorLoginLabel = new Label();
            SuspendLayout();
            // 
            // SignInButton
            // 
            SignInButton.Location = new Point(180, 200);
            SignInButton.Margin = new Padding(2);
            SignInButton.Name = "SignInButton";
            SignInButton.Size = new Size(92, 29);
            SignInButton.TabIndex = 0;
            SignInButton.Text = "Sign in";
            SignInButton.UseVisualStyleBackColor = true;
            SignInButton.Click += SignInButton_Click;
            // 
            // UserNameTextBox
            // 
            UserNameTextBox.Location = new Point(165, 76);
            UserNameTextBox.Margin = new Padding(2);
            UserNameTextBox.Name = "UserNameTextBox";
            UserNameTextBox.Size = new Size(125, 27);
            UserNameTextBox.TabIndex = 1;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(165, 123);
            PasswordTextBox.Margin = new Padding(2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 2;
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(84, 81);
            UsernameLabel.Margin = new Padding(2, 0, 2, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 3;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(84, 123);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Password:";
            // 
            // ErrorUsernameLabel
            // 
            ErrorUsernameLabel.AutoSize = true;
            ErrorUsernameLabel.ForeColor = Color.Red;
            ErrorUsernameLabel.Location = new Point(307, 79);
            ErrorUsernameLabel.Name = "ErrorUsernameLabel";
            ErrorUsernameLabel.Size = new Size(0, 20);
            ErrorUsernameLabel.TabIndex = 5;
            // 
            // ErrorPasswordLabel
            // 
            ErrorPasswordLabel.AutoSize = true;
            ErrorPasswordLabel.ForeColor = Color.Red;
            ErrorPasswordLabel.Location = new Point(307, 126);
            ErrorPasswordLabel.Name = "ErrorPasswordLabel";
            ErrorPasswordLabel.Size = new Size(0, 20);
            ErrorPasswordLabel.TabIndex = 6;
            // 
            // ErrorLoginLabel
            // 
            ErrorLoginLabel.AutoSize = true;
            ErrorLoginLabel.ForeColor = Color.Red;
            ErrorLoginLabel.Location = new Point(123, 167);
            ErrorLoginLabel.Name = "ErrorLoginLabel";
            ErrorLoginLabel.Size = new Size(207, 20);
            ErrorLoginLabel.TabIndex = 7;
            ErrorLoginLabel.Text = "Wrong username or password";
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(ErrorLoginLabel);
            Controls.Add(ErrorPasswordLabel);
            Controls.Add(ErrorUsernameLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Controls.Add(PasswordTextBox);
            Controls.Add(UserNameTextBox);
            Controls.Add(SignInButton);
            Margin = new Padding(2);
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
        private Label ErrorUsernameLabel;
        private Label ErrorPasswordLabel;
        private Label ErrorLoginLabel;
    }
}