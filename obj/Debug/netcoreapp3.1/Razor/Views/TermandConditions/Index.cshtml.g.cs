#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\TermandConditions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fc5a49cc73087c61ba11f4971d1536672d4ca66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TermandConditions_Index), @"mvc.1.0.view", @"/Views/TermandConditions/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fc5a49cc73087c61ba11f4971d1536672d4ca66", @"/Views/TermandConditions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71c36777a35b00391bb04f4b5c2ead5006a0217e", @"/Views/_ViewImports.cshtml")]
    public class Views_TermandConditions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TermandCondition>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\TermandConditions\Index.cshtml"
  
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
                    <h1 style=""color:#3a3d46;font-family: rufina;font-size: 52px;"">Term & Conditions</h1>
                </div>
                <div class=""title-bar-breadcrumb"">
                    <span style=""color: #777777;font-size: 15px;"">Home</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">Term & Conditions</span>
                </div>
            </div>
        </div>
    </div>
</div>

<main class=""termandcondition"">
    <div class=""row"">
");
#nullable restore
#line 26 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\TermandConditions\Index.cshtml"
         foreach (TermandCondition termandCondition in Model)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"terms\">\r\n                <h2>");
#nullable restore
#line 30 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\TermandConditions\Index.cshtml"
               Write(termandCondition.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                <p>\r\n                    ");
#nullable restore
#line 32 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\TermandConditions\Index.cshtml"
               Write(termandCondition.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n");
#nullable restore
#line 35 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\TermandConditions\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</main>\r\n");
#nullable restore
#line 39 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\TermandConditions\Index.cshtml"
Write(await Component.InvokeAsync("NeedSupport"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TermandCondition>> Html { get; private set; }
    }
}
#pragma warning restore 1591
