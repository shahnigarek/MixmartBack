#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Detail), @"mvc.1.0.view", @"/Views/Blog/Detail.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a7", @"/Views/Blog/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9d39968ac3ec5aa31520319a2c0727657aa058d", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/index/blog/post4.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/assets/images/index/blog/post2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteComment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("text-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;border:1px solid #eee;padding:40px 20px;outline:none;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("placeholder", new global::Microsoft.AspNetCore.Html.HtmlString("Your comment"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "addcomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "blog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
  
    ViewData["Title"] = "Detail";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""title-bar""
     style=""background-image: url(/assets/images/index/shop/breadcrumb_bkg2.jpg);background-size: cover;background-position: center;padding: 90px 0px;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""title-bar-text"" style=""text-align: center;"">
                <div class=""title-bar-breadcrumb"">
                    <span style=""color: #777777;font-size: 15px;"">Home</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">Blog</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">Uncategorized</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">
");
            WriteLiteral(@"                        Who Is Kanye West’s Super Stylish
                        Companion?
                    </span>
                </div>
            </div>
        </div>
    </div>
</div>
<main>
    <div class=""article"">
        <div class=""articleinner"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a710894", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1384, "~/assets/images/index/blog/", 1384, 27, true);
#nullable restore
#line 29 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
AddHtmlAttributeValue("", 1411, Model.Blog.Image, 1411, 17, false);

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
            WriteLiteral("\r\n            <div class=\"articletexttitle\">\r\n                <div class=\"articletitle\">\r\n                    <div class=\"categories\">\r\n");
#nullable restore
#line 33 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                         foreach (BlogCategory blogCategory in Model.Blog.BlogCategories)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <a");
            BeginWriteAttribute("href", " href=\"", 1721, "\"", 1728, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 35 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                                  Write(blogCategory.BCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n");
#nullable restore
#line 36 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"

                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                    <h2>");
#nullable restore
#line 39 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                   Write(Model.Blog.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                    <div class=\"admindate\">\r\n                        <p style=\"color: #3a3d46;\">");
#nullable restore
#line 41 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                                              Write(Model.Blog.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <span style=\"padding: 0 5px;\">-</span>\r\n                        <p style=\"color: #777777;\">");
#nullable restore
#line 43 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                                              Write(Model.Blog.Date.ToString("MMMM dd,yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n                <div class=\"articlecontext\">\r\n                    <p>\r\n                        ");
#nullable restore
#line 48 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                   Write(Model.Blog.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n\r\n                    <p class=\"span\">\r\n                        ");
#nullable restore
#line 52 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                   Write(Model.Blog.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n                    </p>\r\n\r\n                </div>\r\n            </div>\r\n            <div class=\"shareon\">\r\n                <div class=\"shareicons\">\r\n                    <span>Share on:</span>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2657, "\"", 2687, 1);
#nullable restore
#line 61 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 2664, Model.Blog.FacebookUrl, 2664, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-facebook-f\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2756, "\"", 2785, 1);
#nullable restore
#line 62 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 2763, Model.Blog.TwitterUrl, 2763, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-twitter\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2851, "\"", 2881, 1);
#nullable restore
#line 63 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 2858, Model.Blog.LinkedinUrl, 2858, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-linkedin-in\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 2951, "\"", 2979, 1);
#nullable restore
#line 64 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 2958, Model.Blog.TumblrUrl, 2958, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-tumblr\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3044, "\"", 3076, 1);
#nullable restore
#line 65 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 3051, Model.Blog.GooglePlusUrl, 3051, 25, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-google-plus-g\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3148, "\"", 3179, 1);
#nullable restore
#line 66 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 3155, Model.Blog.PinterestUrl, 3155, 24, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"fa-brands fa-pinterest\"></i></a>\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 3247, "\"", 3277, 1);
#nullable restore
#line 67 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
WriteAttributeValue("", 3254, Model.Blog.EnvelopeUrl, 3254, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@"><i class=""fa-solid fa-envelope""></i></a>
                </div>
            </div>
        </div>
        <div class=""navigation"">

            <div class=""previousnav"">
                <div class=""navcontent"">
                    <div class=""navimage"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a719043", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"navlink\">\r\n                        <div class=\"title\">\r\n");
            WriteLiteral("                        </div>\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 4660, "\"", 4667, 0);
            EndWriteAttribute();
            WriteLiteral(">Meet the Top 14 Models of Fall <br> 2019</a>\r\n                    </div>\r\n                    <div class=\"navimage\" style=\"padding-left: 10px;\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a720696", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <div class=\"comments\">\r\n");
#nullable restore
#line 107 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
             foreach (var comment in Model.Comments.Where(f => f.IsAccess == true).OrderBy(f => f.Date))
            {
                if (comment.AppUser.UserName == User.Identity.Name)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"comment\">\r\n\r\n                        <div class=\"commentorcomment\">\r\n                            <p style=\"color: #3a3d46;font-weight: 600;\">\r\n                                ");
#nullable restore
#line 115 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                           Write(comment.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 115 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                                                 Write(comment.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <span style=\"color: #777777;font-size: 12px;font-weight: 100;margin-left: 15px;\">\r\n                                    ");
#nullable restore
#line 117 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                               Write(comment.Date.ToString("dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </p>\r\n                            <p class=\"pppp\" style=\"color: #777777;\">\r\n                                ");
#nullable restore
#line 121 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                           Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a724037", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 123 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                                                            WriteLiteral(comment.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 127 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <div class=\"comment\">\r\n\r\n                        <div class=\"commentorcomment\">\r\n                            <p style=\"color: #3a3d46;font-weight: 600;\">\r\n                                ");
#nullable restore
#line 135 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                           Write(comment.AppUser.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 135 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                                                 Write(comment.AppUser.Surname);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                <span style=\"color: #777777;font-size: 12px;font-weight: 100;margin-left: 15px;\">\r\n                                    ");
#nullable restore
#line 137 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                               Write(comment.Date.ToString("dd MMMM yyyy HH:mm"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </span>\r\n                            </p>\r\n                            <p class=\"pppp\" style=\"color: #777777;\">\r\n                                ");
#nullable restore
#line 141 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                           Write(comment.Message);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                        </div>\r\n\r\n                    </div>\r\n");
#nullable restore
#line 146 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"

                }
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </div>
        <div class=""leavereply"">
            <h3>Leave a Reply</h3>
            <p style=""color: #777777;"">
                Your email address will not be published. Required fields are marked <span style=""color: red;"">*</span>
            </p>
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a728868", async() => {
                WriteLiteral("\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "47ebb7e8b3f81d5e077aa8c0bf48ad0e77d2a7a729143", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 157 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Model.Comment.Message);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</input>\r\n\r\n                <button type=\"submit\">Post Comment</button>\r\n\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 156 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
                                                                  WriteLiteral(Model.Blog.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</main>\r\n\r\n");
#nullable restore
#line 166 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\Blog\Detail.cshtml"
Write(await Html.PartialAsync("_ValidationPartial"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
