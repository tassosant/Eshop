namespace Eshop.CustomComponents
{
    partial class Navbar
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.`
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            productsAdministrationFormStripMenuItem = new ToolStripMenuItem();
            userAdministrationFormStripMenuItem = new ToolStripMenuItem();
            browseProductsFormStripMenuItem = new ToolStripMenuItem();
            cartFormStripMenuItem = new ToolStripMenuItem();
            orderFormStripMenuItem = new ToolStripMenuItem();
            paypalGateFormStripMenuItem = new ToolStripMenuItem();
            aboutStripMenuItem = new ToolStripMenuItem();
            logoutStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Items.AddRange(new ToolStripItem[] { productsAdministrationFormStripMenuItem, userAdministrationFormStripMenuItem, browseProductsFormStripMenuItem, cartFormStripMenuItem, orderFormStripMenuItem, paypalGateFormStripMenuItem, aboutStripMenuItem, logoutStripMenuItem });
            menuStrip1.Name = "menuStrip1";
            menuStrip1.ShowItemToolTips = true;
            menuStrip1.Size = new Size(200, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // productsAdministrationFormStripMenuItem
            // 
            productsAdministrationFormStripMenuItem.Name = "productsAdministrationFormStripMenuItem";
            productsAdministrationFormStripMenuItem.Size = new Size(110, 20);
            productsAdministrationFormStripMenuItem.Text = "Edit Products";
            // 
            // userAdministrationFormStripMenuItem
            // 
            userAdministrationFormStripMenuItem.Name = "userAdministrationFormStripMenuItem";
            userAdministrationFormStripMenuItem.Size = new Size(88, 20);
            userAdministrationFormStripMenuItem.Text = "Edit Users";
            // 
            // browseProductsFormStripMenuItem
            // 
            browseProductsFormStripMenuItem.Name = "browseProductsFormStripMenuItem";
            browseProductsFormStripMenuItem.Size = new Size(128, 20);
            browseProductsFormStripMenuItem.Text = "Search Products";
            // 
            // cartFormStripMenuItem
            // 
            cartFormStripMenuItem.Name = "cartFormStripMenuItem";
            cartFormStripMenuItem.Size = new Size(50, 20);
            cartFormStripMenuItem.Text = "Cart";
            // 
            // orderFormStripMenuItem
            // 
            orderFormStripMenuItem.Name = "orderFormStripMenuItem";
            orderFormStripMenuItem.Size = new Size(61, 20);
            orderFormStripMenuItem.Text = "Order";
            // 
            // paypalGateFormStripMenuItem
            // 
            paypalGateFormStripMenuItem.Name = "paypalGateFormStripMenuItem";
            paypalGateFormStripMenuItem.Size = new Size(66, 20);
            paypalGateFormStripMenuItem.Text = "Paypal";
            // 
            // aboutStripMenuItem
            // 
            aboutStripMenuItem.Name = "aboutStripMenuItem";
            aboutStripMenuItem.Size = new Size(64, 20);
            aboutStripMenuItem.Text = "About";
            // 
            // logoutStripMenuItem
            // 
            logoutStripMenuItem.Name = "logoutStripMenuItem";
            logoutStripMenuItem.Size = new Size(70, 20);
            logoutStripMenuItem.Text = "Logout";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem productsAdministrationFormStripMenuItem;
        private ToolStripMenuItem userAdministrationFormStripMenuItem;
        private ToolStripMenuItem browseProductsFormStripMenuItem;
        private ToolStripMenuItem cartFormStripMenuItem;
        private ToolStripMenuItem orderFormStripMenuItem;
        private ToolStripMenuItem paypalGateFormStripMenuItem;
        private ToolStripMenuItem aboutStripMenuItem;
        private ToolStripMenuItem logoutStripMenuItem;
    }
}
