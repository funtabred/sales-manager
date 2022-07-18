using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sales_Management___Project.Services;
using Sales_Management___Project.Entities;

namespace Sales_Management___Project.Pages
{
    public class Page_Update_ProductModel : PageModel
    {
        public List<Category> listCategories = new List<Category>();
        public Product foundProduct = new Product();
        public string keyword = string.Empty;
        public string message = string.Empty;

        [BindProperty(SupportsGet = true)]
        public string productId { get; set; }

        [BindProperty]
        public string productName { get; set; }
        [BindProperty(SupportsGet = true)]
        public string categoryId { get; set; }
        [BindProperty]
        public string manufacturer { get; set; }
        [BindProperty]
        public int price { get; set; }
        [BindProperty]
        public int mfgDate { get; set; }
        [BindProperty]
        public int expiry { get; set; }

        public void OnGet()
        {
            listCategories = Service_Category.SearchCategory(keyword);
            Product? product = Service_Product.GetProduct(productId);
            if (product != null)            
            {
                foundProduct = product.Value;
            }
            else
            {
                message = "Cannot found product";
            }
            
        }
        public void OnPost()
        {
            bool result = Service_Product.UpdateProduct(productId, productName, categoryId, manufacturer, price, mfgDate, expiry);
            if (result)
            {
                message = "Product updated successfully";
            }
            else
                message = "Product updated failed";
        }
    }
}
