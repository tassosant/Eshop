namespace Eshop
{
    partial class CartForm
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            ProductsDataGridView = new DataGridView();
            updateCartButton = new Button();
            navbar1 = new CustomComponents.Navbar(components);
            labelNoProducts = new Label();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(46, 293);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 1;
            label1.Text = "total";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(308, 293);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 2;
            label2.Text = "label2";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(454, 110);
            button1.Margin = new Padding(2, 2, 2, 2);
            button1.Name = "button1";
            button1.Size = new Size(114, 50);
            button1.TabIndex = 3;
            button1.Text = "checkout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.AllowUserToAddRows = false;
            ProductsDataGridView.AllowUserToDeleteRows = false;
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(11, 30);
            ProductsDataGridView.Margin = new Padding(2, 2, 2, 2);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowHeadersWidth = 82;
            ProductsDataGridView.RowTemplate.Height = 41;
            ProductsDataGridView.Size = new Size(410, 188);
            ProductsDataGridView.TabIndex = 4;
            // 
            // updateCartButton
            // 
            updateCartButton.Location = new Point(454, 209);
            updateCartButton.Name = "updateCartButton";
            updateCartButton.Size = new Size(126, 29);
            updateCartButton.TabIndex = 5;
            updateCartButton.Text = "Update Cart";
            updateCartButton.UseVisualStyleBackColor = true;
            updateCartButton.Click += UpdateCartButton_Click;
            // 
            // navbar1
            // 
            navbar1.ImageScalingSize = new Size(32, 32);
            navbar1.Location = new Point(0, 0);
            navbar1.Name = "navbar1";
            navbar1.Padding = new Padding(4, 1, 0, 1);
            navbar1.Size = new Size(640, 26);
            navbar1.TabIndex = 6;
            navbar1.Text = "navbar1";
            navbar1.UserID = 0;
            // 
            // labelNoProducts
            // 
            labelNoProducts.AutoSize = true;
            labelNoProducts.Location = new Point(46, 69);
            labelNoProducts.Name = "labelNoProducts";
            labelNoProducts.Size = new Size(199, 20);
            labelNoProducts.TabIndex = 7;
            labelNoProducts.Text = "There are no products in cart";
            // 
            // CartForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(labelNoProducts);
            Controls.Add(updateCartButton);
            Controls.Add(ProductsDataGridView);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(navbar1);
            MainMenuStrip = navbar1;
            Margin = new Padding(2, 2, 2, 2);
            Name = "CartForm";
            Text = "CartForm";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Button button1;
        private DataGridView ProductsDataGridView;
        private Button updateCartButton;
        private CustomComponents.Navbar navbar1;
        private Label labelNoProducts;
    }
}