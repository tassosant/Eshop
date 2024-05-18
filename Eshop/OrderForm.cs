using Eshop.Controllers;
using Eshop.CustomComponents;
using Eshop.DTOs;
using Eshop.Models.CashRegister;
using Eshop.Services;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Eshop
{
    public partial class OrderForm : Form
    {
        public int UserID { get; set; }
        ArrayList cart;
        float total;
        CartService cartService;
        CartDTO cartDTO;
        public OrderForm(int userID)
        {

            this.UserID = userID;

            InitializeComponent();
            totalPriceLabel.Text = total.ToString();
            MakeStaticLocation();
            InitProperties();
        }
        public OrderForm()
        {
            InitializeComponent();
            totalPriceLabel.Text = total.ToString();
            MakeStaticLocation();
            InitProperties();
        }

        public void InitProperties()
        {
            this.cartService = new CartService();
            //this.cartDTO = cartService.GetOrCreateCart(UserID);
            this.totalPriceLabel.Text = this.cartService.CalculateTotalPrice(this.UserID).ToString();
            InitDataGridView();
            
            

        }

        private void InitDataGridView()
        {
            BindDatasourceToOrder();
            if (this.OrderDataGridView.DataSource != null)
            {
                this.OrderDataGridView.Columns["ProductId"].Visible = false;
                this.OrderDataGridView.ReadOnly = true;
            }
        }

        private void BindDatasourceToOrder()
        {
            if (!FormsController.openForms.ContainsKey(typeof(CartForm)))
            {
                return;
            }
            CartForm cartForm = FormsController.openForms[typeof(CartForm)] as CartForm;
            
            if (cartForm.ProductCartView == null)
            {
                return;
            }
            this.OrderDataGridView.DataSource = cartForm.ProductCartView;
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // confirm order
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // continue to payment total amount
            if (checkBox1.Checked && checkBox2.Checked)
            {
                PaypallGateForm payment = new PaypallGateForm(total);
                payment.ShowDialog();
            }
            else
            {
                MessageBox.Show("confirm prder and shipping details");
            }

        }

        private void calculateTotal(ArrayList cart)
        {
            //float total = 0;
            foreach (var item in cart)
            {
                total += 1;
                //total += item.price * item.quantity;
            }
            totalPriceLabel.Text = total.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MakeStaticLocation()
        {
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(Config.X, Config.Y);
        }

        private void OrderDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}