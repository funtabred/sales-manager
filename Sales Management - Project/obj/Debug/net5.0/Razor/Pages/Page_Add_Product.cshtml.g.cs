#pragma checksum "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\Page_Add_Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2086e4c64f65dc197ffdff3d4af7e9999b3b1de9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Sales_Management___Project.Pages.Pages_Page_Add_Product), @"mvc.1.0.razor-page", @"/Pages/Page_Add_Product.cshtml")]
namespace Sales_Management___Project.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\_ViewImports.cshtml"
using Sales_Management___Project;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\Page_Add_Product.cshtml"
using Sales_Management___Project.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2086e4c64f65dc197ffdff3d4af7e9999b3b1de9", @"/Pages/Page_Add_Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3990f830da920d25c9da47efd057b5166b6040b", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Page_Add_Product : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2086e4c64f65dc197ffdff3d4af7e9999b3b1de93871", async() => {
                WriteLiteral("\r\n    <label>Add a product:</label><br /><br />\r\n\r\n    <label>Product ID:</label><br />\r\n    <input type=\"text\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 266, "\"", 274, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    <label>Product Name:</label><br />                        \r\n    <input type=\"text\" name=\"productName\"");
                BeginWriteAttribute("value", " value=\"", 393, "\"", 401, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    <label>Category:</label><br />\r\n    <select name=\"categoryId\">\r\n");
#nullable restore
#line 17 "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\Page_Add_Product.cshtml"
         foreach (Category category in Model.listCategories)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2086e4c64f65dc197ffdff3d4af7e9999b3b1de95113", async() => {
#nullable restore
#line 19 "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\Page_Add_Product.cshtml"
                                            Write(category.categoryName);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\Page_Add_Product.cshtml"
               WriteLiteral(category.categoryId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\Page_Add_Product.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    </select><br />\r\n\r\n    <label>Manufacturer:</label><br />\r\n    <input type=\"text\" name=\"manufacturer\"");
                BeginWriteAttribute("value", " value=\"", 754, "\"", 762, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n    <label>Price:</label><br />\r\n    <input type=\"number\" min=\"0\" name=\"price\"");
                BeginWriteAttribute("value", " value=\"", 852, "\"", 860, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    <label>Manufactured Date:</label><br />\r\n    <input type=\"number\" min=\"2018\" name=\"mfgDate\"");
                BeginWriteAttribute("value", " value=\"", 969, "\"", 977, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    <label>Expiry:</label><br />\r\n    <input type=\"number\" min=\"0\" name=\"expiry\"");
                BeginWriteAttribute("value", " value=\"", 1071, "\"", 1079, 0);
                EndWriteAttribute();
                WriteLiteral(" /><br />\r\n\r\n    <input type=\"submit\" name=\"submit\" value=\"Save\" />\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 38 "D:\Study\Programming Technique\21880070\Sales Management - Project\Sales Management - Project\Pages\Page_Add_Product.cshtml"
Write(Model.message);

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Sales_Management___Project.Pages.Page_Add_ProductModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sales_Management___Project.Pages.Page_Add_ProductModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Sales_Management___Project.Pages.Page_Add_ProductModel>)PageContext?.ViewData;
        public Sales_Management___Project.Pages.Page_Add_ProductModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
