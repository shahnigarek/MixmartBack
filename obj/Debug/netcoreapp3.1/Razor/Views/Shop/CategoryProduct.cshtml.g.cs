#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad7423d373001b682dac89e5c4993f5e46f2940e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_CategoryProduct), @"mvc.1.0.view", @"/Views/Shop/CategoryProduct.cshtml")]
namespace AspNetCore
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
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.AboutVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.BlogVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.SupportPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.BlogDetailVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Basket;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Header;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Wishlist;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad7423d373001b682dac89e5c4993f5e46f2940e", @"/Views/Shop/CategoryProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c36777a35b00391bb04f4b5c2ead5006a0217e", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_CategoryProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categoryproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "tagproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
  
    ViewData["Title"] = "CategoryProduct";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<main>\r\n    <div class=\"shopcontent\">\r\n        <div class=\"col-lg-3 asidecontent\">\r\n            <div class=\"shopcategories\">\r\n                <h2>Product categories</h2>\r\n                <ul>\r\n");
#nullable restore
#line 12 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                     foreach (Category category in ViewBag.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad7423d373001b682dac89e5c4993f5e46f2940e7093", async() => {
                WriteLiteral(" ");
#nullable restore
#line 15 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                                                                                                          Write(category.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                                                                                    WriteLiteral(category.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <span>(");
#nullable restore
#line 16 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                              Write(category.ProductCategories.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                        </li>\r\n");
#nullable restore
#line 18 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n\r\n            <div class=\"shoptag\">\r\n                <h2>Tags</h2>\r\n                <div class=\"tagcloud\">\r\n");
#nullable restore
#line 27 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                     foreach (Tag tag in ViewBag.Tags)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad7423d373001b682dac89e5c4993f5e46f2940e10900", async() => {
#nullable restore
#line 30 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                                                                                           Write(tag.Name);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                                                                           WriteLiteral(tag.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\" col-lg-9   maincontent\">\r\n       \r\n            <div class=\"productss\">\r\n                <div class=\"row\">\r\n                    ");
#nullable restore
#line 40 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\CategoryProduct.cshtml"
               Write(await Html.PartialAsync("_ProductPartialView", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
