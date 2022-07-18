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
    public class Page_Delete_ProductModel : PageModel
    {
        public string message;
        public Product foundProduct;
        public bool isFound;
        public string categoryName;

        [BindProperty (SupportsGet = true)]
        public string productId { get; set; }
        public void OnGet()
        {
            Product? product = Service_Product.GetProduct(productId);
            if (product != null)
            {
                foundProduct = product.Value;
                categoryName = Service_Category.FindCategoryName(foundProduct.categoryId);
            }
            else
            {
                message = "Product not found";
            }
            isFound = (product != null);
        }
        public void OnPost()
        {
            bool result = Service_Product.DeleteProduct(productId);
            
            message = $"Product {productId} deleted successfully.";
            Response.Redirect("/Page_Product");
            
        }
    }
}
