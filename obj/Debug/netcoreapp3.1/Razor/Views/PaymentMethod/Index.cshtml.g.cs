#pragma checksum "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d73ae94fe013a61e749e7df96bd326c53dd11a47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_PaymentMethod_Index), @"mvc.1.0.view", @"/Views/PaymentMethod/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d73ae94fe013a61e749e7df96bd326c53dd11a47", @"/Views/PaymentMethod/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb6b5ec77c8568db78825c70cc7362dd0f087bb5", @"/Views/_ViewImports.cshtml")]
    public class Views_PaymentMethod_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<PaymentMethod>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
  
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
                    <h1 style=""color:#3a3d46;font-family: rufina;font-size: 52px;"">Payment Method</h1>
                </div>
                <div class=""title-bar-breadcrumb"">
                    <span style=""color: #777777;font-size: 15px;"">Home</span>
                    <i style=""color: #777777;font-size: 8px;padding: 0 10px;"" class=""fa-solid fa-chevron-right""></i>
                    <span style=""color: #3a3d46;font-size: 15px;"">Payment Method</span>
                </div>
            </div>
        </div>
    </div>
</div>

<main class=""pm"" style=""padding: 115px 185px;"">

");
#nullable restore
#line 27 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
     foreach (PaymentMethod paymentMethod in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""paymentmethods"" style=""display: flex;"" data-aos=""fade-up"">
            <div class=""col-lg-6 col-md-6"">
                <div class=""firstquestion"">

                    <div class=""question"" style=""display: flex;"">
                        <div class=""icon""><i class=""fa-regular fa-circle-question""></i></div>
                        <div class=""text"">");
#nullable restore
#line 35 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
                                     Write(paymentMethod.Question1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <p class=\"p\">");
#nullable restore
#line 37 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
                            Write(paymentMethod.Description1);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"ulli\">");
#nullable restore
#line 38 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
                               Write(paymentMethod.PaymentOptions);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    <p class=\"pp\">\r\n                        ");
#nullable restore
#line 40 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
                   Write(paymentMethod.Description2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d73ae94fe013a61e749e7df96bd326c53dd11a478003", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1923, "~/assets/images/index/", 1923, 22, true);
#nullable restore
#line 45 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
AddHtmlAttributeValue("", 1945, paymentMethod.Image, 1945, 20, false);

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
            WriteLiteral(@"
            </div>
        </div>
        <div class=""paymentquestion"" data-aos=""fade-up"">
            <div class=""col-lg-6 col-md-6"">
                <div class=""question"" style=""display: flex;"">
                    <div class=""icon""><i class=""fa-regular fa-circle-question""></i></div>
                    <div class=""text"">");
#nullable restore
#line 52 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
                                 Write(paymentMethod.Question2);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <p class=\"p\">\r\n                    ");
#nullable restore
#line 55 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
               Write(paymentMethod.Description3);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n            <div class=\"col-lg-6 col-md-6\">\r\n                <p class=\"pp\">\r\n                    ");
#nullable restore
#line 60 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
               Write(paymentMethod.Description4);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </p>
            </div>
        </div>
        <div class=""curriencies"" data-aos=""fade-up"">
            <div class=""col-lg-6"">
                <div class=""question"" style=""display: flex;"">
                    <div class=""icon""><i class=""fa-regular fa-circle-question""></i></div>
                    <div class=""text"">");
#nullable restore
#line 68 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
                                 Write(paymentMethod.Question3);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                </div>\r\n                <p class=\"ppp\">\r\n                    ");
#nullable restore
#line 71 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
               Write(paymentMethod.Description5);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </p>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 76 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</main>\r\n");
#nullable restore
#line 78 "C:\Users\ROG\source\repos\MixmartBackEnd\MixmartBackEnd\Views\PaymentMethod\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<PaymentMethod>> Html { get; private set; }
    }
}
#pragma warning restore 1591
