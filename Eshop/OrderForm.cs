using Eshop.DTOs;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Eshop
{
    public partial class OrderForm : Form
    {
        int userID;
        ArrayList cart;
        float total;
        
        public OrderForm(int userID)
        {
            
            this.userID = userID;
            
            InitializeComponent();
            label2.Text=total.ToString();
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
            else {
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
            label2.Text = total.ToString();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
