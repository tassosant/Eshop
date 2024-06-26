﻿using Eshop.Models.Account;
using Eshop.MockDB;
using Eshop.Models.Store;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Eshop.Models.CashRegister;

namespace Eshop.Repositories
{
    internal class ProductRepository
    {
        List<Product> Products { get; set; }
        JSONParser Parser { get; set; }

        public ProductRepository()
        {
            Parser = new JSONParser();
            Products = GetAllProducts();
        }

        public List<Product> GetAllProducts()
        {
            Parser.ParseProductsFileToProducts();
            return Parser.Products;
        }

        public Product GetProductById(int id)
        {
            try
            {
                return Products.First(product => product.ProductId == id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteProductById(int id)
        {
            int index = Products.FindIndex(product => product.ProductId == id);
            Products.RemoveAt(index);
            Parser.OverwriteProductsJSON(Products);
        }

        public void UpdateProduct(Product product)
        {
            int id = product.ProductId;
            int index = Products.FindIndex(product => product.ProductId == id);
            Products[index] = product;
            Parser.OverwriteProductsJSON(Products);
        }

        public void AddProduct(Product product)
        {
            List<Product> products = GetAllProducts().OrderBy(product => product.ProductId).ToList();
            product.ProductId = products.Last().ProductId+1;
            Products.Add(product);
            Parser.OverwriteProductsJSON(Products);
        }

        public void Save(Product product)
        {
            if(GetProductById(product.ProductId) != null)
            {
                UpdateProduct(product);
            }
            else
            {
                AddProduct(product);
            }
        }

        public void SaveAll(List<Product> products)
        {
            Products = products;
            Parser.OverwriteProductsJSON(Products);
        }

        
    }
}
