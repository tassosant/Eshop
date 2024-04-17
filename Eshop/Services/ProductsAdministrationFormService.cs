using Eshop.Models.Store;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    internal class ProductsAdministrationFormService
    {
        CategoryRepository CategoryRepository;
        ProductRepository ProductRepository;

        public ProductsAdministrationFormService()
        {
            CategoryRepository = new CategoryRepository();
            ProductRepository = new ProductRepository();
        }

        public List<Category> GetCategories()
        {
            List<Category> categories = new List<Category>();
            categories = this.CategoryRepository.GetAllCategories();            
            return categories;
        }

        public void UpdateProductsCategory(string categoryName)
        {

        }

        
    }
}
