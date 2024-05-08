using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Views
{
    internal class ProductView
    {
        public Label productNameLabel { get; set; }
        public Label productPriceLabel { get; set; }
        public Button addProductToCart {  get; set; }

        public PictureBox productPictureBox { get; set; }

        public int productId { get; set; }
        public ProductView(Label productName,Label productPrice,Button AddProduct, PictureBox pictureBox) {
            this.productNameLabel = productName;
            this.productPriceLabel = productPrice;
            this.addProductToCart = AddProduct;
            this.productPictureBox = pictureBox;
            this.HideProduct();
        }

        public ProductView() { }

        public void HideProduct()
        {
            this.addProductToCart.Visible = false;
            this.productPriceLabel.Visible = false;
            this.productNameLabel.Visible = false;
        }

        public void ShowProduct()
        {
            this.addProductToCart.Visible = true;
            this.productPriceLabel.Visible = true;
            this.productNameLabel.Visible = true;
        }
    }
}
