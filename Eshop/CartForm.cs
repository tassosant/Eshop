using Eshop.DTOs;
using Eshop.Models.CashRegister;
using Eshop.Models.Store;
using Eshop.Services;
using Eshop.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Eshop
{
    public partial class CartForm : Form
    {

        CartService cartService;
        ProductService productService;
        BindingList<ProductCartView> productCartView;
        CartDTO cartDTO;
        int userId;
        public CartForm(int userID)
        {
            this.userId = userID;
            InitializeComponent();
            InitProperties();
            InitDataGrid();


        }

        private void InitDataGrid()
        {
            BindDatasourceToProductsCart();
            this.ProductsDataGridView.Columns["ProductId"].Visible = false;
            this.ProductsDataGridView.Columns["ProductId"].ReadOnly = true;
            this.ProductsDataGridView.Columns["ProductName"].ReadOnly = true;
        }

        private void BindDatasourceToProductsCart()
        {
            this.ProductsDataGridView.DataSource = this.productCartView;

        }

        private void RefreshDataGrid()
        {
            BindDatasourceToProductsCart();
        }

        private void UpdateCart()
        {
            this.productCartView = (BindingList<ProductCartView>)this.ProductsDataGridView.DataSource;
            ProductCartViewToCartDTO();
            cartService.SaveCart(this.cartDTO);
            RefreshDataGrid();
        }

        private void InitProperties()
        {
            this.cartService = new CartService();
            this.productService = new ProductService();
            this.cartDTO = this.cartService.GetOrCreateCart(this.userId);
            this.productCartView = CartDTOToProductCartView(this.cartDTO);
        }

        private BindingList<ProductCartView> CartDTOToProductCartView(CartDTO cartDTO)
        {
            productCartView = new BindingList<ProductCartView>();
            Dictionary<Product, int> productsDict = cartDTO.Products;

            foreach (KeyValuePair<Product, int> entry in productsDict)
            {
                ProductCartView productCartView = new ProductCartView();
                Product product = entry.Key;
                int quantity = entry.Value;
                productCartView.ProductName = product.Name;
                productCartView.Quantity = quantity;
                productCartView.ProductId = product.ProductId;
                this.productCartView.Add(productCartView);
            }
            return productCartView;
        }

        private void ProductCartViewToCartDTO()
        {

            Dictionary<Product, int> productDict = new Dictionary<Product, int>();
            foreach (ProductCartView productCartViewTemp in this.productCartView)
            {
                if (productCartViewTemp.Quantity > 0)
                {
                    productDict.Add(productService.GetProductById(productCartViewTemp.ProductId), productCartViewTemp.Quantity);
                }
            }
            this.cartDTO.Products = productDict;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculateTotal()
        {



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create order
            OrderForm b = new OrderForm(this.userId);
            b.ShowDialog();
        }

        private void UpdateCartButton_Click(object sender, EventArgs e)
        {
            UpdateCart();
        }
    }
}
