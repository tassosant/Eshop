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
            LoginButton.Location = new Point(292, 133);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(150, 46);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Login";
            LoginButton.UseVisualStyleBackColor = true;
            // 
            // RegisterButton
            // 
            RegisterButton.Location = new Point(292, 207);
            RegisterButton.Name = "RegisterButton";
            RegisterButton.Size = new Size(150, 46);
            RegisterButton.TabIndex = 1;
            RegisterButton.Text = "Sign up";
            RegisterButton.UseVisualStyleBackColor = true;
            // 
            // GuestButton
            // 
            GuestButton.Location = new Point(237, 279);
            GuestButton.Name = "GuestButton";
            GuestButton.Size = new Size(259, 46);
            GuestButton.TabIndex = 2;
            GuestButton.Text = "Continue as guest";
            GuestButton.UseVisualStyleBackColor = true;
            // 
            // WelcomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(GuestButton);
            Controls.Add(RegisterButton);
            Controls.Add(LoginButton);
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