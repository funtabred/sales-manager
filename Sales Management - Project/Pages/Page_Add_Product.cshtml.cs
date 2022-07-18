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
    public class Page_Add_ProductModel : PageModel
    {
        public string keyword = string.Empty;
        public List<Category> listCategories = new List<Category>();
        public string message;

        [BindProperty]
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

        }
        public void OnPost()
        {
            Product newProduct;
            newProduct.productId = productId;
            newProduct.productName = productName;
            newProduct.categoryId = categoryId;
            newProduct.manufacturer = manufacturer;
            newProduct.mfgDate = mfgDate;
            newProduct.expiry = expiry;
            newProduct.price = price;

            bool result = Service_Product.AddProduct(newProduct);
            if (result)
            {
                message = "Product created successfully";
            }
            else
                message = "Failed to create product. Please check your input";
        }

    }
}
