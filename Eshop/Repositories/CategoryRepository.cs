using Eshop.Models.Account;
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
    internal class CategoryRepository
    {
        List<Category> Categories { get; set; }
        JSONParser Parser { get; set; }

        public CategoryRepository()
        {
            Parser = new JSONParser();
            Categories = GetAllCategories();
        }

        public List<Category> GetAllCategories()
        {
            Parser.ParseCategoriesFileToCategories();
            return Parser.Categories;
        }

        public Category GetCategoryById(int id)
        {
            try
            {
                return Categories.First(category => category.CategoryId == id);
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public void DeleteCategoryById(int id)
        {
            int index = Categories.FindIndex(category => category.CategoryId == id);
            Categories.RemoveAt(index);
            Parser.OverwriteCategoriesJSON(Categories);
        }

        public void UpdateCategory(Category category)
        {
            int id = category.CategoryId;
            int index = Categories.FindIndex(category => category.CategoryId == id);
            Categories[index] = category;
            Parser.OverwriteCategoriesJSON(Categories);
        }

        public void AddCategory(Category category)
        {
            List<Category> categories = GetAllCategories().OrderBy(category => category.CategoryId).ToList();
            category.CategoryId = categories.Last().CategoryId + 1;
            Categories.Add(category);
            Parser.OverwriteCategoriesJSON(Categories);
        }

        public void Save(Category category)
        {

            if (GetCategoryById(category.CategoryId)!=null)
            {
                UpdateCategory(category);
            }
            else
            {
                AddCategory(category);
            }
        }

    }
}
