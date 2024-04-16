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
            label3 = new Label();
            EmailLabel = new Label();
            UsernameTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            ConfirmPasswordTextBox = new TextBox();
            EmailTextBox = new TextBox();
            RegisterButton = new Button();
            SuspendLayout();
            // 
            // UsernameLabel
            // 
            UsernameLabel.AutoSize = true;
            UsernameLabel.Location = new Point(163, 77);
            UsernameLabel.Name = "UsernameLabel";
            UsernameLabel.Size = new Size(126, 32);
            UsernameLabel.TabIndex = 0;
            UsernameLabel.Text = "Username:";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Location = new Point(173, 141);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(116, 32);
            PasswordLabel.TabIndex = 1;
            PasswordLabel.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(80, 205);
            label3.Name = "label3";
            label3.Size = new Size(209, 32);
            label3.TabIndex = 2;
            label3.Text = "Confirm Password:";
            // 
            // EmailLabel
            // 
            EmailLabel.AutoSize = true;
            EmailLabel.Location = new Point(213, 263);
            EmailLabel.Name = "EmailLabel";
            EmailLabel.Size = new Size(76, 32);
            EmailLabel.TabIndex = 3;
            EmailLabel.Text = "Email:";
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(326, 80);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(200, 39);
            UsernameTextBox.TabIndex = 4;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Location = new Point(326, 141);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.Size = new Size(200, 39);
            PasswordTextBox.TabIndex = 5;
            // 
            // ConfirmPasswordTextBox
            // 
            ConfirmPasswordTextBox.Location = new Point(326, 202);
            ConfirmPasswordTextBox.Name = "ConfirmPasswordTextBox";
            ConfirmPasswordTextBox.Size = new Size(200, 39);
            ConfirmPasswordTextBox.TabIndex = 6;
            // 
            // EmailTextBox
            // 
            EmailTextBox.Location = new Point(326, 263);
            EmailTextBox.Name = "EmailTextBox";
            EmailTextBox.Size = new Size(200, 39);
            EmailTextBox.TabIndex = 7;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(353, 330);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 46);
            RegisterButton.TabIndex = 8;
            RegisterButton.Text = "Register";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(RegisterButton);
            Controls.Add(EmailTextBox);
            Controls.Add(ConfirmPasswordTextBox);
            Controls.Add(PasswordTextBox);
            Controls.Add(UsernameTextBox);
            Controls.Add(EmailLabel);
            Controls.Add(label3);
            Controls.Add(PasswordLabel);
            Controls.Add(UsernameLabel);
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UsernameLabel;
        private Label PasswordLabel;
        private Label label3;
        private Label EmailLabel;
        private TextBox UsernameTextBox;
        private TextBox PasswordTextBox;
        private TextBox ConfirmPasswordTextBox;
        private TextBox EmailTextBox;
        private Button RegisterButton;
    }
}