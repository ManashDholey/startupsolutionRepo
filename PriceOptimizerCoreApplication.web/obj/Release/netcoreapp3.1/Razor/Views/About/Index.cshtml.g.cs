#pragma checksum "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "90a786f34da777545fd90b7a049766199d59ce97"
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
#line 1 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\_ViewImports.cshtml"
using PriceOptimizerCoreApplication.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\_ViewImports.cshtml"
using PriceOptimizerCoreApplication.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\_ViewImports.cshtml"
using PriceOptimizerCoreApplication.web.Rendering;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\_ViewImports.cshtml"
using PriceOptimizerCoreApplication.web.Util;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"90a786f34da777545fd90b7a049766199d59ce97", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b78c54896d7aeeecc3bee71d7bc8f7d42bebc3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation-unobtrusive/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/site.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/SubcriptionScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 2 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\About\Index.cshtml"
  
    ViewData["Title"] = "About";
    //Layout = "~/Views/Shared/_Layout.cshtml";
    var controller = ViewContext.RouteData.Values["Controller"];
    var action = ViewContext.RouteData.Values["Action"];
    ViewData["Controller"] = controller;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<section class=\"hero-wrap hero-wrap-2\"");
            BeginWriteAttribute("style", " style=\"", 318, "\"", 385, 4);
            WriteAttributeValue("", 326, "background-image:", 326, 17, true);
            WriteAttributeValue(" ", 343, "url(\'", 344, 6, true);
#nullable restore
#line 11 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\About\Index.cshtml"
WriteAttributeValue("", 349, Url.Content("~/images/bg_2.png"), 349, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 382, "\');", 382, 3, true);
            EndWriteAttribute();
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end"">
            <div class=""col-md-9 ftco-animate pb-5"">
                <p class=""breadcrumbs mb-2""><span class=""mr-2""><a href=""http://startupsolution.org.in/"">Home <i class=""ion-ios-arrow-forward""></i></a></span> <span>About us <i class=""ion-ios-arrow-forward""></i></span></p>
                <h1 class=""mb-0 bread"">About Us</h1>
            </div>
        </div>
    </div>
</section>
<section class=""ftco-section ftco-no-pt bg-light"">
    <div class=""container"">
        <div class=""row d-flex no-gutters div-pading-top"">
            <div class=""col-md-6 d-flex "">
                <div class=""img img-video d-flex align-self-stretch align-items-center justify-content-center justify-content-md-center mb-4 mb-sm-0""");
            BeginWriteAttribute("style", " style=\"", 1278, "\"", 1345, 3);
            WriteAttributeValue("", 1286, "background-image:url(\'", 1286, 22, true);
#nullable restore
#line 26 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\About\Index.cshtml"
WriteAttributeValue("", 1308, Url.Content("~/images/about.JPG"), 1308, 34, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1342, "\');", 1342, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                </div>
            </div>
            <div class=""col-md-6 pl-md-5 py-md-5"">
                <div class=""heading-section pl-md-4 pt-md-5"">
                    <span class=""subheading"">Welcome to Accounting</span>
                    <h2 class=""mb-4"">We Are the Best Accounting Agency</h2>
                    <p>Our mission is to digitize accounts in the era of globalization & digitization for ultra growth of organization by saving time & money both. We work with delegation & honesty. We are always trying to deliver before time, error free service. We believe that our growth is in our client’s positive satisfaction & growth.</p>
");
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
#nullable restore
#line 41 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\About\Index.cshtml"
Write(Html.Action("About", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"htmlFooter\">\r\n    ");
#nullable restore
#line 43 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\About\Index.cshtml"
Write(Html.Action("Footer", "About"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a786f34da777545fd90b7a049766199d59ce979311", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a786f34da777545fd90b7a049766199d59ce9710410", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a786f34da777545fd90b7a049766199d59ce9711510", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90a786f34da777545fd90b7a049766199d59ce9712610", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
