using Eshop.MockDB;
using Eshop.Repositories;

namespace Eshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CartRepository cartRepository = new CartRepository();
            cartRepository.GetCartById(10);
            
            
        }
    }
}