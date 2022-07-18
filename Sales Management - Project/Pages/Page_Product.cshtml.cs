using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Sales_Management___Project.Entities;
using Sales_Management___Project.Services;

namespace Sales_Management___Project.Pages
{
    public class Page_ProductModel : PageModel
    {
        public string message;
        public List<Product> listProducts = new List<Product>();
        public List<Category> listCategories = new List<Category>();
        [BindProperty]
        public string keyword { get; set; }
        public void OnGet()
        {
            listProducts = Service_Product.SearchProduct(string.Empty);
            listCategories = Service_Category.GetListCategory();
        }
        public void OnPost()
        {
            listProducts = Service_Product.SearchProduct(keyword);
            listCategories = Service_Category.GetListCategory();
            if (listProducts.Count == 0)
            {                
                message = $"Cannot find any product with '{keyword}'";
            }
        }
    }
}
