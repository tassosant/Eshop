namespace Eshop.Forms
{
    partial class RegisterForm
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
            UsernameLabel = new Label();
            PasswordLabel = new Label();
            ConfirmPasswordLabel = new Label();
            EmailLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ConfirmPasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            RegisterButton = new Button();
            ErrorUsernameLabel = new Label();
            ErrorPasswordLabel = new Label();
            ErrorConfirmPasswordLabel = new Label();
            ErrorEmailLabel = new Label();
            ErrorRegisterLabel = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(100, 48);
            UsernameLabel.Margin = new Padding(2, 0, 2, 0);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(78, 20);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(106, 88);
            PasswordLabel.Margin = new Padding(2, 0, 2, 0);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(73, 20);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // ConfirmPasswordLabel
            // 
            ConfirmPasswordLabel.AutoSize = true;
            ConfirmPasswordLabel.Location = new Point(49, 128);
            ConfirmPasswordLabel.Margin = new Padding(2, 0, 2, 0);
            ConfirmPasswordLabel.Name = "ConfirmPasswordLabel";
            ConfirmPasswordLabel.Size = new Size(130, 20);
            ConfirmPasswordLabel.TabIndex = 2;
            ConfirmPasswordLabel.Text = "Confirm Password:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(131, 164);
            EmailLabel.Margin = new Padding(2, 0, 2, 0);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(49, 20);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "Email:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(201, 50);
            UsernameTextBox.Margin = new Padding(2);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(125, 27);
            UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(201, 88);
            PasswordTextBox.Margin = new Padding(2);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(125, 27);
            PasswordTextBox.TabIndex = 5;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(201, 126);
            ConfirmPasswordTextBox.Margin = new Padding(2);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(125, 27);
            ConfirmPasswordTextBox.TabIndex = 6;
            ConfirmPasswordTextBox.KeyUp += ConfirmPasswordTextBox_KeyUp;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(201, 164);
            EmailTextBox.Margin = new Padding(2);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(125, 27);
            EmailTextBox.TabIndex = 7;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(219, 241);
            RegisterButton.Margin = new Padding(2);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(92, 29);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // ErrorUsernameLabel
            // 
            ErrorUsernameLabel.AutoSize = true;
            ErrorUsernameLabel.ForeColor = Color.Red;
            ErrorUsernameLabel.Location = new Point(360, 53);
            ErrorUsernameLabel.Name = "ErrorUsernameLabel";
            ErrorUsernameLabel.Size = new Size(0, 20);
            ErrorUsernameLabel.TabIndex = 9;
            // 
            // ErrorPasswordLabel
            // 
            ErrorPasswordLabel.AutoSize = true;
            ErrorPasswordLabel.ForeColor = Color.Red;
            ErrorPasswordLabel.Location = new Point(360, 91);
            ErrorPasswordLabel.Name = "ErrorPasswordLabel";
            ErrorPasswordLabel.Size = new Size(0, 20);
            ErrorPasswordLabel.TabIndex = 10;
            // 
            // ErrorConfirmPassowrdLabel
            // 
            ErrorConfirmPasswordLabel.AutoSize = true;
            ErrorConfirmPasswordLabel.ForeColor = Color.Red;
            ErrorConfirmPasswordLabel.Location = new Point(360, 126);
            ErrorConfirmPasswordLabel.Name = "ErrorConfirmPassowrdLabel";
            ErrorConfirmPasswordLabel.Size = new Size(0, 20);
            ErrorConfirmPasswordLabel.TabIndex = 11;
            // 
            // ErrorEmailLabel
            // 
            ErrorEmailLabel.AutoSize = true;
            ErrorEmailLabel.ForeColor = Color.Red;
            ErrorEmailLabel.Location = new Point(360, 167);
            ErrorEmailLabel.Name = "ErrorEmailLabel";
            ErrorEmailLabel.Size = new Size(0, 20);
            ErrorEmailLabel.TabIndex = 12;
            // 
            // ErrorRegisterLabel
            // 
            ErrorRegisterLabel.AutoSize = true;
            ErrorRegisterLabel.ForeColor = Color.Red;
            ErrorRegisterLabel.Location = new Point(258, 203);
            ErrorRegisterLabel.Name = "ErrorRegisterLabel";
            ErrorRegisterLabel.Size = new Size(0, 20);
            ErrorRegisterLabel.TabIndex = 16;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(ErrorRegisterLabel);
            Controls.Add(ErrorEmailLabel);
            Controls.Add(ErrorConfirmPasswordLabel);
            Controls.Add(ErrorPasswordLabel);
            Controls.Add(ErrorUsernameLabel);
            Controls.Add(RegisterButton);
            Controls.Add(EmailTextBox);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(ConfirmPasswordLabel);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Margin = new Padding(2);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

       

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label ConfirmPasswordLabel;
        private Label EmailLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmPasswordTextBox;
        private TextBox EmailTextBox;
        private Button RegisterButton;
        private Label ErrorUsernameLabel;
        private Label ErrorPasswordLabel;
        private Label ErrorConfirmPasswordLabel;
        private Label ErrorEmailLabel;
        private Label ErrorRegisterLabel;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}