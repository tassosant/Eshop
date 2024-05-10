using Eshop.DTOs;
using Eshop.Mappers;
using Eshop.Models.Store;
using Eshop.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eshop.Services
{
    internal class ProductService
    {
        ProductRepository ProductRepository { get; set; }
        
        public ProductService()
        {
            ProductRepository = new ProductRepository();
        
        }

        public List<ProductDTO> GetAllProducts()
        {
            ProductMap productMap = new ProductMap();
            List<ProductDTO> productDTOs = new List<ProductDTO>();
            List<Product> products = ProductRepository.GetAllProducts();
            foreach(Product product in products)
            {
                productDTOs.Add(productMap.MapProductToProductDTO(product));
            }
            return productDTOs;
        }

        public void UpdateProduct(ProductDTO productDTO) { 
            ProductMap productMap = new ProductMap();
            Product product = productMap.MapProductDTOToProduct(productDTO);
            ProductRepository.Save(product);
        }

        public void SaveAllProducts(BindingList<ProductDTO> productsDTOs)
        {
            ProductMap productMap = new ProductMap();
            List<Product> products = new List<Product>();
            foreach(ProductDTO productDTO in productsDTOs)
            {
                products.Add(productMap.MapProductDTOToProduct(productDTO));
            }
        }

        public Product GetProductById(int id)
        {
            return ProductRepository.GetProductById(id);
        }

        
    }
}
