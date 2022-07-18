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
    public class Page_Create_CategoryModel : PageModel
    {
        public string message;

        [BindProperty]
        public string categoryId { get; set; }

        [BindProperty]
        public string categoryName { get; set; }
        public void OnGet()
        {
        }

        public void OnPost()
        {
            Category newCategory;
            newCategory.categoryId = categoryId;
            newCategory.categoryName = categoryName;

            bool result = Service_Category.CreateNewCategory(newCategory);
            if (result)
            {
                message = "New category created.";
            }
            else
                message = "Failed to create a new category. Please check your input";
        }
    }
}
