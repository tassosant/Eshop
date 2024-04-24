using Eshop.Models.CashRegister;
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
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Eshop
{
    public partial class CartForm : Form
    {
        ArrayList cart;
        int userID;
        float total = 0;
        public CartForm(ArrayList cart, int userID)
        {
            this.cart = cart;
            this.userID = userID;
            string text = "";
            InitializeComponent();
            foreach (var item in cart)
            {
                text += item.ToString();
            }

            richTextBox1.Text = text;
            calculateTotal(cart);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void calculateTotal(ArrayList cart)
        {
            
            foreach (var item in cart)
            {
                total += 1;
                //total += item.price * item.quantity;
            }
            label2.Text = total.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // create order
            OrderForm b = new OrderForm(userID, cart, total);
            b.ShowDialog();
        }
    }
}
