using Eshop.DTOs;
using Eshop.Models.Store;
using Eshop.Repositories;
using Eshop.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop.Forms
{
    public partial class ProductsAdministrationForm : Form
    {
        ProductsAdministrationFormService productsAdministrationFormService;
        ProductService productService;
        BindingList<ProductDTO> ProductDTOs { get; set; }

        public int UserID { get; set; }

        public ProductsAdministrationForm(int userID)
        {
            this.UserID = userID;
            InitializeComponent();            
            InitProperties();
            MakeDropDownMenu();
            AddEvents();
        }

        public ProductsAdministrationForm()
        {
            InitializeComponent();
            InitProperties();
            MakeDropDownMenu();
            AddEvents();
        }

        private void InitProperties()
        {
            productsAdministrationFormService = new ProductsAdministrationFormService();
            productService = new ProductService();
            InitDataGrid();

        }

        private void InitDataGrid()
        {
            BindDatasourceToProducts();
            this.ProductsDataGridView.Columns["CategoryId"].Visible = false;
            this.ProductsDataGridView.Columns["Image"].Visible = false;
            //this.ProductsDataGridView.Columns["CategoryNameCombo"].Visible = false;
        }

        private void AddEvents()
        {
            AddDataGridEvents();
        }

        private void AddDataGridEvents()
        {
            ProductsDataGridView.CellValueChanged += ProductsDataGridView_CellValueChanged;
        }

        private void MakeDropDownMenu()
        {
            List<Category> categories = productsAdministrationFormService.GetCategories();
            string[] categoryNames = categories.Select(category => category.CategoryName).ToArray();
            // Create a new DataGridViewComboBoxColumn
            DataGridViewComboBoxColumn comboColumn = new DataGridViewComboBoxColumn();
            comboColumn.HeaderText = "Category";
            comboColumn.Name = "CategoryNameCombo";
            comboColumn.DataPropertyName = "CategoryNameCombo"; // Bind to the property in the data source
            //comboColumn.DataSource = new string[] { "Admin", "User", "Guest" }; // Example list of roles
            comboColumn.DataSource = categoryNames;
            comboColumn.ValueType = typeof(string);

            // Add the combo column to the DataGridView
            this.ProductsDataGridView.Columns.Add(comboColumn);
            this.ProductsDataGridView.Columns["CategoryNameCombo"].Visible = false;
        }

        private void ProductsDataGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ProductsDataGridView.Columns["CategoryNameCombo"].Index && e.RowIndex >= 0)
            {
                // Action to take when a new role is selected
                string selectedCategory = (string)ProductsDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                int productId = Int32.Parse(ProductsDataGridView.Rows[e.RowIndex].Cells["Id"].Value.ToString());
                productsAdministrationFormService.UpdateProductsCategory(productId, selectedCategory);
                MessageBox.Show("Category changed to:" + selectedCategory);
                RefreshDataGrid();
            }
        }

        private void EditCategoriesButton_Click(object sender, EventArgs e)
        {
            this.ProductsDataGridView.Columns["CategoryNameCombo"].Visible = true;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            this.ProductsDataGridView.Columns["CategoryNameCombo"].Visible = false;
        }

        private void RefreshDataGrid()
        {
            BindDatasourceToProducts();
        }

        private void BindDatasourceToProducts()
        {
            List<ProductDTO> productDTOsTemp = productService.GetAllProducts();
            ProductDTOs = new BindingList<ProductDTO>(productDTOsTemp);
            this.ProductsDataGridView.DataSource = ProductDTOs;
        }
    }
}
