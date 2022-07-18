using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using Sales_Management___Project.Entities;
using Newtonsoft.Json;

namespace Sales_Management___Project.Data_Access
{
    public class DataAccess_Product
    {
        public static bool SaveProduct(Product product)
        {
            List<Product> listProduct = GetProducts();
            listProduct.Add(product);
            SaveListProduct(listProduct);
            return true;
        }
        public static List<Product> GetProducts()
        {
            StreamReader reader = new StreamReader("wwwroot/Data Container/product.json");
            string jsonString = reader.ReadToEnd();
            reader.Close();
            List<Product> listProduct = JsonConvert.DeserializeObject<List<Product>>(jsonString);
            return listProduct;
        }
        public static bool SaveListProduct(List<Product> listProduct)
        {
            StreamWriter writer = new StreamWriter("wwwroot/Data Container/product.json");
            string jsonString = JsonConvert.SerializeObject(listProduct);
            writer.Write(jsonString);
            writer.Close();
            return true;
        }
        public static bool DeleteProduct(string id)
        {
            int index = -1;
            List<Product> listProduct = DataAccess_Product.GetProducts();
            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].categoryId.Equals(id))
                {
                    index = i;
                }
            }
            if (index != -1)
            {
                listProduct.RemoveAt(index);                
                return SaveListProduct(listProduct); ;
            }
            else
                return false;
        }
        public static bool UpdateProduct(Product deletingProduct)
        {
            List<Product> listProduct = GetProducts();            

            for (int i = 0; i < listProduct.Count; i++)
            {
                if (listProduct[i].productId == deletingProduct.productId)
                {
                    listProduct[i] = deletingProduct;
                    SaveListProduct(listProduct);
                    return true;
                }
            }
            return false;
        }
    }
}
