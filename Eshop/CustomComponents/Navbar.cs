using Eshop.Controllers;
using Eshop.Forms;
using Eshop.Views;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;


namespace Eshop.CustomComponents
{
    [ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.MenuStrip)]
    public partial class Navbar : System.Windows.Forms.MenuStrip
    {

        private Hashtable menuItems;

        private ArrayList menuItemViews;

        public int UserID {  get; set; }
        public Navbar()
        {
            InitializeComponent();
            CollectMenuItems();
            MakeMenuItemsVisible();
            AddEventsInMenuItems();
        }

        public Navbar(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
            CollectMenuItems();
            MakeMenuItemsVisible();
            AddEventsInMenuItems();
        }

        private void CollectMenuItems()
        {
            this.SuspendLayout();

            this.menuItems = new Hashtable();
            
            this.menuItems.Add(this.productsAdministrationFormStripMenuItem,typeof(ProductsAdministrationForm));
            this.menuItems.Add(this.userAdministrationFormStripMenuItem,typeof(UserAdministrationForm));
            this.menuItems.Add(this.browseProductsFormStripMenuItem,typeof(BrowseProductsForm));
            this.menuItems.Add(this.cartFormStripMenuItem,typeof(CartForm));
            this.menuItems.Add(this.orderFormStripMenuItem,typeof(OrderForm));
            this.menuItems.Add(this.paypalGateFormStripMenuItem,typeof(PaypallGateForm));
            this.menuItems.Add(this.aboutStripMenuItem,typeof(MessageBox));

            this.menuItemViews = new ArrayList();            
            this.menuItemViews.Add(new StripMenuItemView(this.productsAdministrationFormStripMenuItem,typeof(ProductsAdministrationForm)));
            this.menuItemViews.Add(new StripMenuItemView(this.userAdministrationFormStripMenuItem,typeof(UserAdministrationForm)));
            this.menuItemViews.Add(new StripMenuItemView(this.browseProductsFormStripMenuItem,typeof(BrowseProductsForm)));
            this.menuItemViews.Add(new StripMenuItemView(this.cartFormStripMenuItem,typeof(CartForm)));
            this.menuItemViews.Add(new StripMenuItemView(this.orderFormStripMenuItem,typeof(OrderForm)));
            this.menuItemViews.Add(new StripMenuItemView(this.paypalGateFormStripMenuItem,typeof(PaypallGateForm)));
            this.menuItemViews.Add(new StripMenuItemView(this.aboutStripMenuItem, typeof(MessageBox)));

            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public void UpdateUserID(Type type,int userID)
        {
            //StripMenuItemView menuItemView = FindByType(type);
            //menuItemView.UserID = userID;
            foreach (StripMenuItemView stripMenuItemView in this.menuItemViews)
            {
                stripMenuItemView.UserID = userID;
            }
            this.UserID = userID;
        }

        private StripMenuItemView FindByType(Type type)
        {
            foreach(StripMenuItemView stripMenuItemView in this.menuItemViews)
            {
                if (stripMenuItemView.FormType == type)
                {
                    return stripMenuItemView;
                }
            }
            return null;
        }

        

        private void MakeMenuItemsVisible()
        {
            this.SuspendLayout();
            if (!DesignMode)
            {
                //List<ToolStripItem> toolStripItems =  this.menuStrip1.Items.Cast<List<ToolStripItem>>;
                //foreach(ToolStripMenuItem item in this.menuItems.Keys)
                //{
                //    //this.Items.Add(item);
                //}
                this.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                    this.productsAdministrationFormStripMenuItem,
                    this.userAdministrationFormStripMenuItem,
                    this.browseProductsFormStripMenuItem,
                    this.cartFormStripMenuItem,
                    this.orderFormStripMenuItem,
                    this.paypalGateFormStripMenuItem,
                    this.aboutStripMenuItem
                });
            }
            this.ResumeLayout(false);
        }

        private void AddEventsInMenuItems()
        {
            AddClickEvent();
        }

        private void AddClickEvent()
        {
            foreach (ToolStripMenuItem item in this.menuItems.Keys)
            {
                item.Click += (sender, e) => NavbarItemClicked(sender, e, (Type)this.menuItems[item]);
            }
        }

        private void NavbarItemClicked(object sender, EventArgs e, Type formType)
        {

            //if is about button
            if (formType == typeof(MessageBox))
            {
                FillMessageBox();
                return;
            }

            Type currentFormType = this.Parent.GetType();
            Type formTypeToNavigate = formType;

            if (formTypeToNavigate != currentFormType)
            {
                //Form form = (Form)Activator.CreateInstance(formType);
                //form.Show();
                FormsController.ShowForm(formTypeToNavigate,this.UserID);
                //if(currentFormType!=typeof(Form1)){
                //    this.Parent.Dispose();
                //}
            }
        }

        private void FillMessageBox()
        {

            string msg = String.Format("Tasos Antoniou\nEuaggelia Thermou");
            string title = "Creators";
            MessageBox.Show(msg, title);
        }
    }
}
