#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f832", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d39968ac3ec5aa31520319a2c0727657aa058d", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "categoryproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "tagproduct", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "wishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToWishlist", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addtowishlist"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "basket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("addbasket"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""title-bar""
     style=""background-image: url(/assets/images/index/shop/breadcrumb_bkg2.jpg);background-size: cover;background-position: center;padding: 45px 0px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""title-bar-text"" style=""text-align: center;"">
                <div class=""title-bar-header"" style=""margin-bottom: 20px;"">
                    <h1 style=""color:#3a3d46;font-family: rufina;font-size: 52px;"">Shop</h1>
                </div>
                <div class=""title-bar-breadcrumb"">
                    <span style=""color: #777777;font-size: 15px;"">Home</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">Shop</span>
                </div>
            </div>
        </div>
    </div>
</div>
<main>
    <div class=""shopcontent"">
        <div class=""col-lg-3 asidecontent"">
            <div class=""shopcat");
            WriteLiteral("egories\">\r\n                <h2>Product categories</h2>\r\n                <ul>\r\n");
#nullable restore
#line 29 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                     foreach (Category category in Model.Categories)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li >\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f83210683", async() => {
#nullable restore
#line 32 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
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
#line 32 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
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
#line 33 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                              Write(category.ProductCategories.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(")</span>\r\n                        </li>\r\n");
#nullable restore
#line 35 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </ul>\r\n            </div>\r\n\r\n            <div class=\"shoptag\">\r\n                <h2>Tags</h2>\r\n                <div class=\"tagcloud\">\r\n");
#nullable restore
#line 44 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                     foreach (Tag tag in Model.Tags)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f83214403", async() => {
#nullable restore
#line 47 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
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
#line 47 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
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
#line 48 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\" col-lg-9   maincontent\">\r\n        \r\n            <div class=\"productss\">\r\n                <div class=\"row\">\r\n");
#nullable restore
#line 57 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                     foreach (Product product in Model.Products)
                    {

                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-6\" style=\" margin-top: 45px;\">\r\n                                <div class=\"productcart\">\r\n                                    <div style=\"position:relative\" class=\"product-image\">\r\n");
#nullable restore
#line 64 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                         if (product.DiscountedPrice > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span class=\"onsale\">-");
#nullable restore
#line 66 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                              Write((((product.Price * 100) / product.DiscountedPrice) - 100).ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 67 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f83219019", async() => {
                WriteLiteral("\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f83219319", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 2947, "~/assets/images/index/shop/", 2947, 27, true);
#nullable restore
#line 70 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
AddHtmlAttributeValue("", 2974, product.Image, 2974, 14, false);

#line default
#line hidden
#nullable disable
                EndAddHtmlAttributeValues(__tagHelperExecutionContext);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 69 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                                       WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"action\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f83223314", async() => {
                WriteLiteral("<i class=\"fa-regular fa-heart\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 75 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                                                  WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f83225886", async() => {
                WriteLiteral("<i class=\"fa-brands fa-opencart\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 76 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                                              WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                    </div>\r\n                                    <div class=\"product-caption\">\r\n                                        <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26f6791a7bf5e5d3b2c29a97b38c0a6c1d63f83228582", async() => {
#nullable restore
#line 80 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                                                               Write(product.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 80 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                                           WriteLiteral(product.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h3>\r\n");
#nullable restore
#line 81 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                         if (product.DiscountedPrice > 0)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span style=\"color: #b3b3b3;text-decoration: line-through;font-size: 14px;\"\r\n                                                  class=\"old-price\">$");
#nullable restore
#line 84 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                <span class=\"price\">$");
#nullable restore
#line 85 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                Write(product.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 86 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"price\">$");
#nullable restore
#line 89 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                                                Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 90 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"
                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n\r\n                            </div>\r\n");
#nullable restore
#line 96 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Index.cshtml"


                       
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
