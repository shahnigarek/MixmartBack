#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cb3bba8990d8bdd45be3833753e105da201d856"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Manage_Views_Blog_Details), @"mvc.1.0.view", @"/Areas/Manage/Views/Blog/Details.cshtml")]
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
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.Interfaces;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.Shop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.AboutVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.BlogVM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.ViewModels.SupportPage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\_ViewImports.cshtml"
using MixmartBackEnd.Areas.Manage.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cb3bba8990d8bdd45be3833753e105da201d856", @"/Areas/Manage/Views/Blog/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ce01420fbed199a2e9f0da45d09ba2df803ee69c", @"/Areas/Manage/Views/_ViewImports.cshtml")]
    public class Areas_Manage_Views_Blog_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Blog>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("<main class=\"main-content position-relative max-height-vh-100 h-100 border-radius-lg  \" style=\"padding-top:40px\">\r\n    <div>\r\n        <h4>Blog Details</h4>\r\n        <hr />\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 12 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 15 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
       Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 19 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 22 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description1));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 25 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 28 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description2));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 31 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.BCategoryIds));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 34 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
             foreach (BlogCategory blogCategory in Model.BlogCategories)
            {



#line default
#line hidden
#nullable disable
            WriteLiteral("            <dd>");
#nullable restore
#line 38 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
           Write(blogCategory.BCategory.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n");
#nullable restore
#line 39 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"


        }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 44 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 48 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
           Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n           \r\n        </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cb3bba8990d8bdd45be3833753e105da201d8569726", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 53 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Areas\Manage\Views\Blog\Details.cshtml"
                                 WriteLiteral(Model.Id);

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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0cb3bba8990d8bdd45be3833753e105da201d85611893", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</main>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
