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
    public class Page_Update_CategoryModel : PageModel
    {
        public string message;
        public Category foundCategory;
        public bool isFound;

        [BindProperty(SupportsGet = true)]
        public string categoryId { get; set; }

        [BindProperty]
        public string categoryName { get; set; }
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
            Category updatingCategory;
            updatingCategory.categoryId = categoryId;
            updatingCategory.categoryName = categoryName;

            bool result = Service_Category.UpdateCategory(updatingCategory);
            if (result)
            {
                message = "Category updated.";
            }
            else
                message = "Failed to update category. Please check your input";
            Response.Redirect("/Page_Categories");
        }
    }
}
