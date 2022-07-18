using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales_Management___Project.Entities;
using Newtonsoft.Json;
using System.IO;

namespace Sales_Management___Project.Data_Access
{
    public class DataAccess_Category
    {
        public static bool SaveCategory (Category newCategory)
        {
            List<Category> listCategories = GetCategories();
            listCategories.Add(newCategory);
            SaveCategoryList(listCategories);
            return true;
        }
        public static bool UpdateCategory (Category updatingCategory)
        {
            List<Category> listCategories = GetCategories();
            for (int i = 0; i < listCategories.Count; i++)
            {
                if (listCategories[i].categoryId.Equals(updatingCategory.categoryId))
                {
                    listCategories[i] = updatingCategory;
                    SaveCategoryList(listCategories);
                    return true;
                }
            }
            return false;
        }
        public static List<Category> GetCategories()
        {
            StreamReader reader = new StreamReader("wwwroot/Data Container/category.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<Category> listCategories;
            listCategories = JsonConvert.DeserializeObject<List<Category>>(jsonString);
            
            return listCategories;
        }
        public static bool SaveCategoryList(List<Category> listCategories)
        {
            StreamWriter writer = new StreamWriter("wwwroot/Data Container/category.json");
            string jsonString = JsonConvert.SerializeObject(listCategories);
            writer.Write(jsonString);
            writer.Close();
            return true;
        }
        public static bool DeleteCategory (string categoryId)
        {
            int index = -1;
            List<Category> listCategories = GetCategories();
            for (int i = 0; i < listCategories.Count; i++)
            {
                if (listCategories[i].categoryId.Equals(categoryId))
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                listCategories.RemoveAt(index);
                SaveCategoryList(listCategories);
                return true;
            }
            return false;               
        }
    }
}
