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
    public class Page_CategoriesModel : PageModel
    {
        public List<Category> listCategories;
        public string message;

        [BindProperty]
        public string keyword { get; set; }
        public void OnGet()
        {
            listCategories = Service_Category.SearchCategory(string.Empty);
        }
        public void OnPost()
        {
            listCategories = Service_Category.SearchCategory(keyword);
            if(listCategories.Count == 0)
            {
                message = $"Cannot find any categories with '{keyword}'";
            }
        }
    }
}
