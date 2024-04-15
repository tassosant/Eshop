using Eshop.MockDB;

namespace Eshop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            JSONParser parser = new JSONParser();
            parser.ParseCartsFileToCarts();
            parser.AddToCarts();
            
        }
    }
}