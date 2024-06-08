using Eshop.Controllers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.CustomComponents
{
    public static class CloseFormHandler
    {

        public static void HandleLogoutMenuItem(ToolStripMenuItem sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to logout?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                 
                return;
            }
            sender.GetCurrentParent().Parent.Dispose();
            Application.Exit();
        }

        public static void HandleClosingForm(Form sender,FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No)
            {
                e.Cancel = true;
                return;
            }
            Debug.WriteLine("Closure approved:"+sender.GetType().ToString());
            foreach(Form form in FormsController.openForms.Values)
            {
                
                form.Dispose();
            }
            sender.Dispose();
            Application.Exit();
        }
    }
}
