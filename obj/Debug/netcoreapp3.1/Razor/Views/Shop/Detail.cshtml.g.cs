#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8158f9a21ad4d1d7762ad5fcf63e37102e939f6"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8158f9a21ad4d1d7762ad5fcf63e37102e939f6", @"/Views/Shop/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6841c9b49a9e1d630d777955923bd30da2dffd4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Shop_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width: 810px; height: 810px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/index/shop/shop5.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/index/shop/shop1.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/index/shop/shop3.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8158f9a21ad4d1d7762ad5fcf63e37102e939f68533", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1361, "~/assets/images/index/shop/", 1361, 27, true);
#nullable restore
#line 27 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Shop\Detail.cshtml"
AddHtmlAttributeValue("", 1388, Model.Product.Image, 1388, 20, false);

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
            BeginWriteAttribute("href", " href=\"", 2046, "\"", 2053, 0);
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f8158f9a21ad4d1d7762ad5fcf63e37102e939f614518", async() => {
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
            BeginWriteAttribute("href", " href=\"", 3814, "\"", 3821, 0);
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
            BeginWriteAttribute("href", "\r\n                                   href=\"", 4214, "\"", 4257, 0);
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
            WriteLiteral("                        </span>\r\n                    </div>\r\n                    <div class=\"socialshare\">\r\n                        <span>Share on:</span>\r\n                       \r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4536, "\"", 4543, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-facebook-f\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4616, "\"", 4623, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4693, "\"", 4700, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-linkedin-in\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4774, "\"", 4781, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-tumblr\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4850, "\"", 4857, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-google-plus-g\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4933, "\"", 4940, 0);
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-pinterest\"></i></a>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5012, "\"", 5019, 0);
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa-solid fa-envelope""></i></a>
                    </div>
                </div>
            </div>


            <div class=""relatedproducts"">
                <h2>Related products</h2>
                <div class=""relatedproductss"">
                    <div class=""row"">
                      
                        <div class=""col-lg-4 col-md-4"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 5425, "\"", 5433, 0);
            EndWriteAttribute();
            WriteLiteral(@" style="" margin-top: 45px;"">
                                <div class=""productcart"">
                                    <div class=""product-image"" style=""position: relative;"">
                                        <span class=""onsale"">-23%</span>
                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8158f9a21ad4d1d7762ad5fcf63e37102e939f620316", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"product-caption\">\r\n                                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 5944, "\"", 5951, 0);
            EndWriteAttribute();
            WriteLiteral(@">Walnut Cutting Board</a></h3>
                                        <span style=""color: #b3b3b3;text-decoration: line-through;font-size: 14px;""
                                              class=""old-price"">$300.00</span>
                                        <span class=""price"">$230.00</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 6498, "\"", 6506, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\" margin-top: 45px;\">\r\n                                <div class=\"productcart\">\r\n                                    <div class=\"product-image\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8158f9a21ad4d1d7762ad5fcf63e37102e939f622637", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"product-caption\">\r\n                                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 6915, "\"", 6922, 0);
            EndWriteAttribute();
            WriteLiteral(@">10″ Lido Bamboo Plate</a></h3>
                                        <span class=""price"">$12.00</span>
                                    </div>
                                </div>
                            </div>

                        </div>
                        <div class=""col-lg-4 col-md-4"">
                            <div");
            BeginWriteAttribute("class", " class=\"", 7274, "\"", 7282, 0);
            EndWriteAttribute();
            WriteLiteral(" style=\" margin-top: 45px;\">\r\n                                <div class=\"productcart\">\r\n                                    <div class=\"product-image\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f8158f9a21ad4d1d7762ad5fcf63e37102e939f624759", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                    <div class=\"product-caption\">\r\n                                        <h3><a");
            BeginWriteAttribute("href", " href=\"", 7691, "\"", 7698, 0);
            EndWriteAttribute();
            WriteLiteral(@">11 oz Ceramic Mug in Black</a></h3>
                                        <span class=""price"">$24.00</span>
                                    </div>
                                </div>
                            </div>

                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</main>

");
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
