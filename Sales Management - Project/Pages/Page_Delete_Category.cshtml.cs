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
    public class Page_Delete_CategoryModel : PageModel
    {
        public string message;
        public bool isFound;
        public Category foundCategory;

        [BindProperty(SupportsGet = true)]
        public string categoryId { get; set; }

        public void OnGet()
        {
            Category? category = Service_Category.GetCategory(categoryId);
            if (category != null)
            {
                foundCategory = category.Value;
            }
            else
                message = "Can not find input category";
            isFound = (category != null);
        }
        public void OnPost()
        {
            bool result = Service_Category.DeleteCategory(categoryId);
            if (result)
            {
                message = $"Category {categoryId} deleted successfully.";
                Response.Redirect("/Page_Categories");
            }
            else
                message = $"Failed to delete category {categoryId}";

        }
    }
}
