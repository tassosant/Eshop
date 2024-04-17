using Eshop.DTOs;
using Eshop.Mappers;
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

        public void UpdateProductsCategory(ProductDTO productDTO, string categoryName)
        {
            ProductMap productMap = new ProductMap();
            Category category = this.CategoryRepository.GetCategoryByName(categoryName);
            int categoryId = category.CategoryId;
            productDTO.CategoryId = categoryId;
            Product product = productMap.MapProductDTOToProduct(productDTO);
            this.ProductRepository.Save(product);

        }

        public void UpdateProductsCategory(int productId, string categoryName)
        {
            
            Category category = this.CategoryRepository.GetCategoryByName(categoryName);
            int categoryId = category.CategoryId;
            
            Product product = this.ProductRepository.GetProductById(productId);
            product.CategoryId = categoryId; 
            this.ProductRepository.Save(product);

        }


    }
}
