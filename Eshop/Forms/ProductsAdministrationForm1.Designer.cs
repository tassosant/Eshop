namespace Eshop.Forms
{
    partial class ProductsAdministrationForm
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
            ProductsDataGridView = new DataGridView();
            SaveButton = new Button();
            DeleteButton = new Button();
            EditCategoriesButton = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).BeginInit();
            SuspendLayout();
            // 
            // ProductsDataGridView
            // 
            ProductsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductsDataGridView.Location = new Point(2, 48);
            ProductsDataGridView.Name = "ProductsDataGridView";
            ProductsDataGridView.RowHeadersWidth = 82;
            ProductsDataGridView.RowTemplate.Height = 41;
            ProductsDataGridView.Size = new Size(1058, 300);
            ProductsDataGridView.TabIndex = 0;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(162, 499);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(150, 46);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(134, 407);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(221, 46);
            DeleteButton.TabIndex = 2;
            DeleteButton.Text = "Delete selected";
            DeleteButton.UseVisualStyleBackColor = true;
            // 
            // EditCategoriesButton
            // 
            EditCategoriesButton.Location = new Point(402, 499);
            EditCategoriesButton.Name = "EditCategoriesButton";
            EditCategoriesButton.Size = new Size(235, 46);
            EditCategoriesButton.TabIndex = 3;
            EditCategoriesButton.Text = "Edit Category";
            EditCategoriesButton.UseVisualStyleBackColor = true;
            EditCategoriesButton.Click += EditCategoriesButton_Click;
            // 
            // ProductsAdministrationForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1376, 653);
            Controls.Add(EditCategoriesButton);
            Controls.Add(DeleteButton);
            Controls.Add(SaveButton);
            Controls.Add(ProductsDataGridView);
            Name = "ProductsAdministrationForm";
            Text = "ProductsAdministrationForm1";
            ((System.ComponentModel.ISupportInitialize)ProductsDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView ProductsDataGridView;
        private Button SaveButton;
        private Button DeleteButton;
        private Button EditCategoriesButton;
    }
}