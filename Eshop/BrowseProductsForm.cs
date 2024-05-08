using Eshop.DTOs;
using Eshop.Services;
using Eshop.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eshop
{
    public partial class BrowseProductsForm : Form
    {
        ProductService productService;
        ArrayList cart = new ArrayList();
        int userID;
        ArrayList products = new ArrayList();
        ArrayList productPageViews = new ArrayList();
        ArrayList productDTOs = new ArrayList();
        int productsPerPage = 4;
        int pages;
        int lastPageProducts; //number of last page products
        int selectedPage;


        public BrowseProductsForm(int userID, ArrayList cart)
        {
            InitializeComponent();
            InitProperties();
            ShowProducts(1);
            
            
            this.cart = cart;
            this.userID = userID;
            //products.Add("product1");
            //products.Add("product2");
            //products.Add("product3");
            //ShowProducts(products);

        }

        private void ShowProducts(int page)
        {
            if(page > this.pages)
            {
                int firstProductIndex = this.pages*productsPerPage;
                int lastProductIndex = firstProductIndex+this.lastPageProducts-1;
                int viewIndex = 0;
                for(int productIndex = firstProductIndex;productIndex <= lastProductIndex; productIndex++)
                {
                    MapProductDTOToView(this.productDTOs[productIndex],this.productPageViews[viewIndex]);
                    
                    viewIndex++;                        
                }
                for (int hideIndex = viewIndex; hideIndex < this.productsPerPage;hideIndex++)
                {
                    ProductView productView = (ProductView) this.productPageViews[hideIndex];
                    productView.HideProduct();
                }
                return;
            }
            //this.SuspendLayout();
            //foreach (var item in products)
            //{
            //    Button button = new Button();
            //    button.Text = item.ToString();
            //}
            //this.ResumeLayout();

        }

        

        private void BrowseProductsForm_Load(object sender, EventArgs e)
        {

        }

        private void InitProperties()
        {
            MapProductFormControlsToProductViews();
            this.productService = new ProductService();
            this.productDTOs = new ArrayList(this.productService.GetAllProducts());
            this.pages = this.productDTOs.Count/this.productsPerPage;
            this.lastPageProducts = this.productDTOs.Count%this.productsPerPage;
            this.selectedPage = 1;
        }

        private void ButtonAddProduct_Click(object sender, EventArgs e, int id)
        {
             MessageBox.Show("id:"+id+" added to cart");
        }

        private void ButtonAddProduct1_Click(object sender, EventArgs e)
        { // add teapot to cart
          // add product to cart
            int productID = 0;
            String productName = "product 1";
            cart.Add(productID);
            MessageBox.Show(productName + " is added in your cart");
        }

        private void ButtonAddProduct2_Click(object sender, EventArgs e)
        { // add teapot to cart
          // add product to cart
          
        }

        private void ButtonAddProduct3_Click(object sender, EventArgs e)
        { // add teapot to cart
          // add product to cart

        }
        private void ButtonAddProduct4_Click(object sender, EventArgs e)
        { // add teapot to cart
          // add product to cart

        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            // view teapot
            ProductForm productForm = new ProductForm(userID, cart);
            productForm.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            CartForm cartform = new CartForm(cart, userID);
            cartform.ShowDialog();
        }

        private void ButtonPreviousPage_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNextPage_Click(object sender, EventArgs e)
        {

        }

      

        private void MapProductDTOToView(Object productDTO2, Object productView2)
        {
            ProductDTO productDTO=(ProductDTO)productDTO2;
            ProductView productView = (ProductView) productView2;
            productView.productId = productDTO.Id;
            productView.productPriceLabel.Text=productDTO.Price.ToString();
            productView.productNameLabel.Text=productDTO.Name.ToString();
            byte[] bytes = Convert.FromBase64String(productDTO.Image);
            Image image;
            using (MemoryStream ms = new MemoryStream(bytes))
            {
                image = Image.FromStream(ms);
            }
            productView.productPictureBox.Image = image;
            productView.ShowProduct();            
        }

        private void MapProductFormControlsToProductViews()
        {
            this.productPageViews.Add(MapProductView1());           
            this.productPageViews.Add(MapProductView2());           
            this.productPageViews.Add(MapProductView3());           
            this.productPageViews.Add(MapProductView4());           
        }

        private ProductView MapProductView1()
        {
            ProductView productView = new ProductView();
            productView.productNameLabel = this.labelProduct1Name;
            productView.productPriceLabel = this.labelProduct1Price;
            productView.addProductToCart = this.buttonAddProduct1;
            productView.productPictureBox = this.pictureBoxProduct1;
            productView.addProductToCart.Click += (sender, EventArgs) => { ButtonAddProduct_Click(sender, EventArgs, productView.productId); };
            return productView;
        }
        private ProductView MapProductView2()
        {
            ProductView productView = new ProductView();
            productView.productNameLabel = this.labelProduct2Name;
            productView.productPriceLabel = this.labelProduct2Price;
            productView.addProductToCart = this.buttonAddProduct2;
            productView.productPictureBox = this.pictureBoxProduct2;
            productView.addProductToCart.Click += (sender, EventArgs) =>{ButtonAddProduct_Click(sender,EventArgs, productView.productId);};
            return productView;
        }
        private ProductView MapProductView3()
        {
            ProductView productView = new ProductView();
            productView.productNameLabel = this.labelProduct3Name;
            productView.productPriceLabel = this.labelProduct3Price;
            productView.addProductToCart = this.buttonAddProduct3;
            productView.productPictureBox = this.pictureBoxProduct3;
            productView.addProductToCart.Click += (sender, EventArgs) =>{ButtonAddProduct_Click(sender,EventArgs, productView.productId);};
            return productView;
        }
        private ProductView MapProductView4()
        {
            ProductView productView = new ProductView();
            productView.productNameLabel = this.labelProduct4Name;
            productView.productPriceLabel = this.labelProduct4Price;
            productView.addProductToCart = this.buttonAddProduct4;
            productView.productPictureBox = this.pictureBoxProduct4;
            productView.addProductToCart.Click += (sender, EventArgs) =>{ButtonAddProduct_Click(sender,EventArgs, productView.productId);};
            return productView;
        }

        
    }
}
