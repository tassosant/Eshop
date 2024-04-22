using Eshop.DTOs;
using Eshop.Models.Store;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Mappers
{
    internal class ProductMap
    {
        /*
         public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Quantity { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }

          public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public float Price { get; set; }
         */
        public ProductMap() { }

        public Product MapProductDTOToProduct(ProductDTO productDTO)
        {
            Product product = new Product();
            product.ProductId = productDTO.Id;
            product.Name = productDTO.Name;
            product.Image = productDTO.Image;
            product.Description = productDTO.Description;
            product.Price = productDTO.Price;
            product.Quantity = productDTO.Quantity;
            product.CategoryId=productDTO.CategoryId;

            return product;
        }

        public ProductDTO MapProductToProductDTO(Product product)
        {
            ProductDTO productDTO = new ProductDTO();
            productDTO.Id = product.ProductId;
            productDTO.Name=product.Name; 
            productDTO.Image = product.Image;
            productDTO.Description=product.Description; 
            productDTO.Price = product.Price;
            productDTO.Quantity = product.Quantity;
            Category category = ConvertCategoryIdToCategory(product.CategoryId);
            productDTO.CategoryId=category.CategoryId;
            productDTO.CategoryName=category.CategoryName;
            return productDTO;
        }

        public ProductDTO MapProductToProductDTO(Product product,Category category)
        {
            ProductDTO productDTO = new ProductDTO();
            productDTO.Id = product.ProductId;
            productDTO.Name = product.Name;
            productDTO.Image = product.Image;
            productDTO.Description = product.Description;
            productDTO.Price = product.Price;
            productDTO.Quantity = product.Quantity;            
            productDTO.CategoryId = category.CategoryId;
            productDTO.CategoryName = category.CategoryName;
            return productDTO;
        }

        private Category ConvertCategoryIdToCategory(int categoryId)
        {
            CategoryRepository categoryRepository = new CategoryRepository();
            
            Category category = categoryRepository.GetCategoryById(categoryId);

            return category;
        }
    }
}
