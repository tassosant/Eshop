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

namespace Eshop
{
    public partial class OrderForm : Form
    { 
        float total;
        public OrderForm()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            // confirm order
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // continue to payment total amount
            PaypallGateForm payment = new PaypallGateForm(total);
            payment.ShowDialog();
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
