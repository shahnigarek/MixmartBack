#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c36777a35b00391bb04f4b5c2ead5006a0217e", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "shop", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
  
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
                    <h1 style=""color:#3a3d46;font-family: rufina;font-size: 52px;"">About Us</h1>
                </div>
                <div class=""title-bar-breadcrumb"">
                    <span style=""color: #777777;font-size: 15px;"">Home</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">About Us</span>
                </div>
            </div>
        </div>
    </div>
</div>

<main class=""about"">
    <div class=""row"">
        <div class=""phrase"">
            <div class=""imgabo");
            WriteLiteral("ut\" data-aos=\"zoom-in\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e7762", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1132, "~/assets/images/index/blog/", 1132, 27, true);
#nullable restore
#line 28 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1159, Model.About.Image, 1159, 18, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"phrasetext\" data-aos=\"fade-up\">\r\n                <p>\r\n                    “");
#nullable restore
#line 32 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                Write(Model.About.Phrase);

#line default
#line hidden
#nullable disable
            WriteLiteral("”\r\n                </p>\r\n            </div>\r\n        </div>\r\n        <div class=\"brands\" data-aos=\"fade-up\">\r\n");
#nullable restore
#line 37 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
             foreach (Brand brand in Model.Brands)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"brandimg col-lg-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e10151", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1560, "~/assets/images/index/brand/", 1560, 28, true);
#nullable restore
#line 39 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1588, brand.Image, 1588, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 40 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"brandslider\">\r\n");
#nullable restore
#line 45 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
             foreach (Brand brand in Model.Brands)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"brandimg\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e12314", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1802, "~/assets/images/index/brand/", 1802, 28, true);
#nullable restore
#line 47 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1830, brand.Image, 1830, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 48 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"brandslider1\">\r\n");
#nullable restore
#line 53 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
             foreach (Brand brand in Model.Brands)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"brandimg col-lg-2\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e14487", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2054, "~/assets/images/index/brand/", 2054, 28, true);
#nullable restore
#line 55 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 2082, brand.Image, 2082, 12, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n");
#nullable restore
#line 56 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"story\">\r\n            <div class=\"storytext\" data-aos=\"fade-up\">\r\n                <p class=\"s\">");
#nullable restore
#line 62 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                        Write(Model.Story.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p>\r\n                    ");
#nullable restore
#line 64 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
               Write(Html.Raw(Model.Story.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e17027", async() => {
                WriteLiteral("<button>Shop Now</button>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <div class=\"storyvideo col-lg-3\"");
            BeginWriteAttribute("style", " style=\"", 2538, "\"", 2615, 4);
            WriteAttributeValue("", 2546, "background-image:", 2546, 17, true);
            WriteAttributeValue(" ", 2563, "url(/assets/images/index/error/", 2564, 32, true);
#nullable restore
#line 68 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
WriteAttributeValue("", 2595, Model.Story.Image, 2595, 18, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2613, ");", 2613, 2, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"playicon\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2681, "\"", 2709, 1);
#nullable restore
#line 70 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
WriteAttributeValue("", 2688, Model.Story.VideoUrl, 2688, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-solid fa-play\"></i></a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"services\" data-aos=\"fade-up\">\r\n");
#nullable restore
#line 75 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
             foreach (Service service in Model.Services)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"servicecontent col-lg-3 col-md-6\">\r\n                    <div class=\"serviceicon\">");
#nullable restore
#line 78 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                                        Write(Html.Raw(service.Icon));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    <div class=\"servicetext\">\r\n                        <h3>");
#nullable restore
#line 80 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                       Write(service.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                        <p>");
#nullable restore
#line 81 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                      Write(service.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 84 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""team"">
            <div class=""top"" style=""text-align: center;"" data-aos=""fade-up"">
                <div class=""team-text"">
                    <p>SHOP BY CATEGORIES</p>
                </div>
                <div class=""team-image"">
                    <h2 style=""font-size: 62px;color: #3a3d46;"">Team Members</h2>
                </div>
            </div>
            <div class=""teammembers"" style=""display: flex;margin-bottom: 140px;"" data-aos=""fade-up"">
");
#nullable restore
#line 98 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                 foreach (Team team in Model.Teams)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"col-lg-3 col-md-6\">\r\n                        <div class=\"memberimage\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6d1ae6909ca6229f2c7b88a88f52b1f7eac2964e22129", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3982, "~/assets/images/index/team/", 3982, 27, true);
#nullable restore
#line 101 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 4009, team.Image, 4009, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</div>\r\n\r\n                        <div class=\"memberinfo\">\r\n                            <p class=\"name\">");
#nullable restore
#line 104 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                                       Write(team.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n                            <p class=\"position\">");
#nullable restore
#line 105 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"
                                           Write(team.Position.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                   \r\n\r\n                    </div>\r\n");
#nullable restore
#line 110 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\About\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
