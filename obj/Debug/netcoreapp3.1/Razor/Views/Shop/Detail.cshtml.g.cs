#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "64c1afb268734ed4800d267a36db5d3dc4282ae2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Detail), @"mvc.1.0.view", @"/Views/Shop/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64c1afb268734ed4800d267a36db5d3dc4282ae2", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6841c9b49a9e1d630d777955923bd30da2dffd4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 810px; height: 810px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""title-bar""
     style=""background-image: url(/assets/images/index/shop/breadcrumb_bkg2.jpg);background-size: cover;background-position: center;padding: 85px 0px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""title-bar-text"" style=""text-align: center;"">
                <div class=""title-bar-breadcrumb"">
                    <span style=""color: #777777;font-size: 15px;"">Home</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">Products</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">Uncategorized</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;");
            WriteLiteral("\">Peach Wood Chopsticks</span>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<main>\r\n    <div class=\"productcontent\">\r\n        <div class=\"row\">\r\n            <div class=\"col-lg-7\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "64c1afb268734ed4800d267a36db5d3dc4282ae28153", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1367, "~/assets/images/index/shop/", 1367, 27, true);
#nullable restore
#line 27 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 1394, Model.Product.Image, 1394, 20, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"col-lg-5\">\r\n                <div class=\"productinfo\">\r\n                    <h1>");
#nullable restore
#line 31 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                   Write(Model.Product.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
                    <div class=""productrating"">
                        <div class=""staricon"">
                            <i class=""fa-solid fa-star""></i>
                            <i class=""fa-solid fa-star""></i>
                            <i class=""fa-solid fa-star""></i>
                            <i class=""fa-solid fa-star""></i>
                            <i class=""fa-solid fa-star-half-stroke""></i>
                        </div>
                        <a");
            BeginWriteAttribute("href", " href=\"", 2052, "\"", 2059, 0);
            EndWriteAttribute();
            WriteLiteral(">(5 customer reviews)</a>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                     if (Model.Product.DiscountedPrice > 0)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <span style=\"color: #b3b3b3;text-decoration: line-through;font-size: 14px;\"\r\n                              class=\"old-price\">$");
#nullable restore
#line 45 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                            Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                            <span class=\"price\">$");
#nullable restore
#line 46 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                            Write(Model.Product.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 47 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span class=\"price\">$");
#nullable restore
#line 50 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                            Write(Model.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 51 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"productdetails\">\r\n                        <p class=\"p\">\r\n                            ");
#nullable restore
#line 54 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                       Write(Model.Product.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <p style=\"margin-top: 30px;font-weight: 400;font-size: 15px;color: #777777;\">\r\n                            ");
#nullable restore
#line 57 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                       Write(Model.Product.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </p>\r\n                        <ul style=\"padding-left: 0px;margin-bottom: 24px;\">\r\n                            <li>\r\n                                ");
#nullable restore
#line 61 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                           Write(Model.Product.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </li>\r\n                        </ul>\r\n                    </div>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64c1afb268734ed4800d267a36db5d3dc4282ae214138", async() => {
                WriteLiteral(@"
                        <div class=""buttons"">
                            <input type=""number"" value=""1"" id=""quantity"" name=""quantity"" min=""1"" max=""90"">
                        </div>
                        <button>
                            <i style=""margin-right: 10px;"" class=""fa-brands fa-opencart""></i>Add To
                            Cart
                        </button>
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div class=\"addtowishlist\">\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 3820, "\"", 3827, 0);
            EndWriteAttribute();
            WriteLiteral("> + Add to Wishlist</a>\r\n                    </div>\r\n                    <div class=\"categoryproduct\">\r\n                        <span style=\"display: block;color: #333;line-height: 2;\">\r\n                            Category:");
#nullable restore
#line 79 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                      foreach (ProductCategory productCategory in Model.Product.ProductCategories)
                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <a style=\"color: #777777;\"");
            BeginWriteAttribute("href", "\r\n                                   href=\"", 4220, "\"", 4263, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 82 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                      Write(productCategory.Category.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(",</a>\r\n");
#nullable restore
#line 83 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"

                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </span>\r\n                    </div>\r\n                    <div class=\"socialshare\">\r\n                        <span>Share on:</span>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4519, "\"", 4526, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-facebook-f\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4599, "\"", 4606, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4676, "\"", 4683, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-linkedin-in\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4757, "\"", 4764, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-tumblr\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4833, "\"", 4840, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-google-plus-g\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4916, "\"", 4923, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-pinterest\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4995, "\"", 5002, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa-solid fa-envelope""></i></a>
                    </div>
                </div>
            </div>


            <div class=""relatedproducts"">
                <h2>Related products</h2>
                <div class=""relatedproductss"">
                    <div class=""row"">

");
#nullable restore
#line 107 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                         foreach (Product product in Model.Products.Take(3))
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col-lg-4 col-md-4\">\r\n                                <div");
            BeginWriteAttribute("class", " class=\"", 5501, "\"", 5509, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\" margin-top: 45px;\">\r\n                                    <div class=\"productcart\">\r\n                                        <div style=\"position:relative\" class=\"product-image\">\r\n");
#nullable restore
#line 114 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                             if (product.DiscountedPrice > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span class=\"onsale\">-");
#nullable restore
#line 116 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                                                  Write((((product.Price * 100) / product.DiscountedPrice) - 100).ToString("0.##"));

#line default
#line hidden
#nullable disable
            WriteLiteral("%</span>\r\n");
#nullable restore
#line 117 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"

                                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "64c1afb268734ed4800d267a36db5d3dc4282ae221132", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 6084, "~/assets/images/index/shop/", 6084, 27, true);
#nullable restore
#line 119 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 6111, product.Image, 6111, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"product-caption\">\r\n                                            <h3>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "64c1afb268734ed4800d267a36db5d3dc4282ae222893", async() => {
#nullable restore
#line 122 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                                                                                                   Write(product.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
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
#line 123 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                             if (product.DiscountedPrice > 0)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <span style=\"color: #b3b3b3;text-decoration: line-through;font-size: 14px;\"\r\n                                                      class=\"old-price\">$");
#nullable restore
#line 126 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                    <span class=\"price\">$");
#nullable restore
#line 127 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                                                    Write(product.DiscountedPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 128 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                                }
                                                else
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <span class=\"price\">$");
#nullable restore
#line 131 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                                                    Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 132 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                        </div>\r\n                                    </div>\r\n\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 139 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
