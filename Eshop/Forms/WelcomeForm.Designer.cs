namespace Eshop.Forms
{
    partial class WelcomeForm
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
            LoginButton = new Button();
            RegisterButton = new Button();
            GuestButton = new Button();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Location = new Point(180, 83);
            LoginButton.Margin = new Padding(2, 2, 2, 2);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(92, 29);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(180, 129);
            RegisterButton.Margin = new Padding(2, 2, 2, 2);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(92, 29);
            RegisterButton.TabIndex = 1;
            RegisterButton.Text = "Sign up";
            RegisterButton.UseVisualStyleBackColor = true;
            RegisterButton.Click += RegisterButton_Click;
            // 
            // GuestButton
            // 
            GuestButton.Location = new Point(146, 174);
            GuestButton.Margin = new Padding(2, 2, 2, 2);
            GuestButton.Name = "GuestButton";
            GuestButton.Size = new Size(159, 29);
            GuestButton.TabIndex = 2;
            GuestButton.Text = "Continue as guest";
            GuestButton.UseVisualStyleBackColor = true;
            GuestButton.Click += GuestButton_Click;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(492, 281);
            Controls.Add(GuestButton);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
            Margin = new Padding(2, 2, 2, 2);
            Name = "WelcomeForm";
            Text = "WelcomeForm";
            ResumeLayout(false);
        }

        #endregion

        private Button LoginButton;
        private Button RegisterButton;
        private Button GuestButton;
    }
}