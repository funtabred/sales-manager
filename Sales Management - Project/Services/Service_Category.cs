using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales_Management___Project.Entities;
using Sales_Management___Project.Data_Access;

namespace Sales_Management___Project.Services
{
    public class Service_Category
    {
        public static bool CreateNewCategory(Category newCategory)
        {
            switch(ValidateInput(newCategory) && CheckNotDuplicate(newCategory)){
                case false:
                    return false;
                default:
                    return DataAccess_Category.SaveCategory(newCategory);
            }
        }
        public static bool ValidateInput(Category category)
        {
            if (string.IsNullOrWhiteSpace(category.categoryId) || string.IsNullOrWhiteSpace(category.categoryName))
            {
                return false;
            }
            return true;
        }
        public static bool CheckNotDuplicate(Category category)
        {
            List<Category> listCategory = DataAccess_Category.GetCategories();
            foreach (Category currentCategory in listCategory)
            {
                if (currentCategory.categoryId.Equals(category.categoryId))
                {
                    return false;
                }
            }
            return true;
        }
        public static Category? GetCategory(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return null;
            }
            List<Category> listCategories = DataAccess_Category.GetCategories();
            foreach (Category currentCategory in listCategories)
            {
                if (currentCategory.categoryId.Equals(id))
                {
                    return currentCategory;
                }
            }
            return null;
        }
        public static bool UpdateCategory (Category updatingCategory)
        {
            switch (string.IsNullOrWhiteSpace(updatingCategory.categoryName))
            {
                case false:
                    return false;
                default:
                    return DataAccess_Category.UpdateCategory(updatingCategory);
            }
        }
        public static List<Category> SearchCategory(string keyword)
        {
            if (keyword == null)
            {
                keyword = string.Empty;
            }
            List<Category> currentListCategories = DataAccess_Category.GetCategories();
            List<Category> foundResult = new List<Category>();
            foreach (Category category in currentListCategories)
            {
                if (category.categoryName.Contains(keyword))
                {
                    foundResult.Add(category);
                }
            }
            return foundResult;
        }
        public static bool DeleteCategory(string categoryId)
        {
            switch (string.IsNullOrEmpty(categoryId))
            {
                case true:
                    return false;
                default:
                    return DataAccess_Category.DeleteCategory(categoryId);
            }
        }
        public static List<Category> GetListCategory()
        {
            return DataAccess_Category.GetCategories();
        }
        public static string FindCategoryName(string id)
        {
            List<Category> listCategory = DataAccess_Category.GetCategories();
            foreach(Category category in listCategory)
            {
                if (category.categoryId.Equals(id))
                {
                    return category.categoryName;
                }
            }
            return string.Empty;
        }
    }
}
