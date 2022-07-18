using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Sales_Management___Project.Data_Access;
using Sales_Management___Project.Entities;

namespace Sales_Management___Project.Services
{
    public class Service_Product
    {
        public static bool AddProduct(Product product)
        {
            if (!ValidateInput(product) || !CheckDuplicate(product) || !CheckValidCategory(product))
            {
                return false;
            }
            return DataAccess_Product.SaveProduct(product);
        }
        public static List<Product> SearchProduct(string keyword)
        {
            List<Product> listCurrentProducts = DataAccess_Product.GetProducts();
            List<Product> listFoundProducts = new List<Product>();
            foreach (Product currentProduct in listCurrentProducts)
            {
                if (currentProduct.productName.Contains(keyword))
                {
                    listFoundProducts.Add(currentProduct);
                }
            }
            return listFoundProducts;
        }
        public static bool ValidateInput(Product product)
        {
            if (string.IsNullOrWhiteSpace(product.productId) || string.IsNullOrWhiteSpace(product.productName) || string.IsNullOrWhiteSpace(product.categoryId) || string.IsNullOrWhiteSpace(product.manufacturer))
            {
                return false;
            }
            return true;
        }
        public static bool CheckDuplicate(Product product)
        {
            List<Product> listProduct = DataAccess_Product.GetProducts();
            foreach(Product currentProduct in listProduct)
            {
                if (currentProduct.productId.Equals(product.productId))
                {
                    return false;
                }
            }
            return true;
        }
        public static bool CheckValidCategory(Product product)
        {
            List<Category> listCategories = DataAccess_Category.GetCategories();
            foreach(Category currentCategory in listCategories)
            {
                if (currentCategory.categoryId.Equals(product.categoryId))
                {
                    return true;
                }
            }
            return false;
        }
        public static Product? GetProduct(string productId)
        {
            if (string.IsNullOrEmpty(productId))
            {
                return null;
            }
            List<Product> listProduct = DataAccess_Product.GetProducts();
            foreach (Product currentProduct in listProduct)
            {
                if (currentProduct.productId.Equals(productId))
                {
                    return currentProduct;
                }
            }
            return null;
        }
        public static bool DeleteProduct(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                return false;
            }
            return DataAccess_Product.DeleteProduct(id);
        }
        public static bool UpdateProduct(string productId, string productName, string categoryId, string manufacturer, int price, int mfgDate, int expiry)
        {
            if (string.IsNullOrWhiteSpace(productId) ||
                string.IsNullOrWhiteSpace(productName) ||
                string.IsNullOrWhiteSpace(manufacturer) ||
                string.IsNullOrWhiteSpace(categoryId))
            {
                return false;
            }
            Product foundProduct = new Product();
            foundProduct.productName = productName;
            foundProduct.categoryId = categoryId;
            foundProduct.manufacturer = manufacturer;
            foundProduct.mfgDate = mfgDate;
            foundProduct.price = price;
            foundProduct.expiry = expiry;
            return DataAccess_Product.UpdateProduct(foundProduct);
        }
    }
}
