#pragma checksum "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c5f43ecef028822fd3ca1134d8cc72703d5d113"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c5f43ecef028822fd3ca1134d8cc72703d5d113", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b78c54896d7aeeecc3bee71d7bc8f7d42bebc3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
#nullable restore
#line 1 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
  
    ViewData["Title"] = "Blog Page";
    var controller = ViewContext.RouteData.Values["Controller"];
    var action = ViewContext.RouteData.Values["Action"];
    ViewData["Controller"] = controller;
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<section class=\"hero-wrap hero-wrap-2\"");
            BeginWriteAttribute("style", " style=\"", 253, "\"", 320, 4);
            WriteAttributeValue("", 261, "background-image:", 261, 17, true);
            WriteAttributeValue(" ", 278, "url(\'", 279, 6, true);
#nullable restore
#line 7 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 284, Url.Content("~/images/bg_2.jpg"), 284, 33, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 317, "\');", 317, 3, true);
            EndWriteAttribute();
            WriteLiteral(@" data-stellar-background-ratio=""0.5"">
    <div class=""overlay""></div>
    <div class=""container"">
        <div class=""row no-gutters slider-text align-items-end"">
            <div class=""col-md-9 ftco-animate pb-5"">
                <p class=""breadcrumbs mb-2""><span class=""mr-2""><a href=""http://startupsolution.org.in/"">Home <i class=""ion-ios-arrow-forward""></i></a></span> <span>Blog <i class=""ion-ios-arrow-forward""></i></span></p>
                <h1 class=""mb-0 bread"">Blog</h1>
            </div>
        </div>
    </div>
</section>

<section class=""ftco-section"">
    <div class=""container"">
        <div class=""row d-flex"">
            <div class=""col-md-4 d-flex ftco-animate"">
                <div class=""blog-entry align-self-stretch"">
                    <a href=""blog-single.html"" class=""block-20 rounded""");
            BeginWriteAttribute("style", " style=\"", 1156, "\"", 1226, 4);
            WriteAttributeValue("", 1164, "background-image:", 1164, 17, true);
            WriteAttributeValue(" ", 1181, "url(\'", 1182, 6, true);
#nullable restore
#line 24 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 1187, Url.Content("~/images/image_1.jpg"), 1187, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1223, "\');", 1223, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text p-4"">
                        <div class=""meta mb-2"">
                            <div><a href=""#"">March 31, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                            <div><a href=""#"" class=""meta-chat""><span class=""fa fa-comment""></span> 3</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 d-flex ftco-animate"">
                <div class=""blog-entry align-self-stretch"">
                    <a href=""blog-single.html"" class=""block-20 rounded""");
            BeginWriteAttribute("style", " style=\"", 2020, "\"", 2090, 4);
            WriteAttributeValue("", 2028, "background-image:", 2028, 17, true);
            WriteAttributeValue(" ", 2045, "url(\'", 2046, 6, true);
#nullable restore
#line 38 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2051, Url.Content("~/images/image_2.jpg"), 2051, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2087, "\');", 2087, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text p-4"">
                        <div class=""meta mb-2"">
                            <div><a href=""#"">March 31, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                            <div><a href=""#"" class=""meta-chat""><span class=""fa fa-comment""></span> 3</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 d-flex ftco-animate"">
                <div class=""blog-entry align-self-stretch"">
                    <a href=""blog-single.html"" class=""block-20 rounded""");
            BeginWriteAttribute("style", " style=\"", 2884, "\"", 2954, 4);
            WriteAttributeValue("", 2892, "background-image:", 2892, 17, true);
            WriteAttributeValue(" ", 2909, "url(\'", 2910, 6, true);
#nullable restore
#line 52 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 2915, Url.Content("~/images/image_3.jpg"), 2915, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2951, "\');", 2951, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text p-4"">
                        <div class=""meta mb-2"">
                            <div><a href=""#"">March 31, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                            <div><a href=""#"" class=""meta-chat""><span class=""fa fa-comment""></span> 3</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                    </div>
                </div>
            </div>

            <div class=""col-md-4 d-flex ftco-animate"">
                <div class=""blog-entry align-self-stretch"">
                    <a href=""blog-single.html"" class=""block-20 rounded""");
            BeginWriteAttribute("style", " style=\"", 3750, "\"", 3820, 4);
            WriteAttributeValue("", 3758, "background-image:", 3758, 17, true);
            WriteAttributeValue(" ", 3775, "url(\'", 3776, 6, true);
#nullable restore
#line 67 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 3781, Url.Content("~/images/image_4.jpg"), 3781, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3817, "\');", 3817, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text p-4"">
                        <div class=""meta mb-2"">
                            <div><a href=""#"">March 31, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                            <div><a href=""#"" class=""meta-chat""><span class=""fa fa-comment""></span> 3</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 d-flex ftco-animate"">
                <div class=""blog-entry align-self-stretch"">
                    <a href=""blog-single.html"" class=""block-20 rounded""");
            BeginWriteAttribute("style", " style=\"", 4614, "\"", 4684, 4);
            WriteAttributeValue("", 4622, "background-image:", 4622, 17, true);
            WriteAttributeValue(" ", 4639, "url(\'", 4640, 6, true);
#nullable restore
#line 81 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 4645, Url.Content("~/images/image_5.jpg"), 4645, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4681, "\');", 4681, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text p-4"">
                        <div class=""meta mb-2"">
                            <div><a href=""#"">March 31, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                            <div><a href=""#"" class=""meta-chat""><span class=""fa fa-comment""></span> 3</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                    </div>
                </div>
            </div>
            <div class=""col-md-4 d-flex ftco-animate"">
                <div class=""blog-entry align-self-stretch"">
                    <a href=""blog-single.html"" class=""block-20 rounded""");
            BeginWriteAttribute("style", " style=\"", 5478, "\"", 5548, 4);
            WriteAttributeValue("", 5486, "background-image:", 5486, 17, true);
            WriteAttributeValue(" ", 5503, "url(\'", 5504, 6, true);
#nullable restore
#line 95 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Blog\Index.cshtml"
WriteAttributeValue("", 5509, Url.Content("~/images/image_6.jpg"), 5509, 36, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5545, "\');", 5545, 3, true);
            EndWriteAttribute();
            WriteLiteral(@">
                    </a>
                    <div class=""text p-4"">
                        <div class=""meta mb-2"">
                            <div><a href=""#"">March 31, 2020</a></div>
                            <div><a href=""#"">Admin</a></div>
                            <div><a href=""#"" class=""meta-chat""><span class=""fa fa-comment""></span> 3</a></div>
                        </div>
                        <h3 class=""heading""><a href=""#"">Even the all-powerful Pointing has no control about the blind texts</a></h3>
                    </div>
                </div>
            </div>
        </div>
        <div class=""row mt-5"">
            <div class=""col text-center"">
                <div class=""block-27"">
                    <ul>
                        <li><a href=""#"">&lt;</a></li>
                        <li class=""active""><span>1</span></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li><a href=""#""");
            WriteLiteral(">4</a></li>\r\n                        <li><a href=\"#\">5</a></li>\r\n                        <li><a href=\"#\">&gt;</a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n");
            WriteLiteral("\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5f43ecef028822fd3ca1134d8cc72703d5d11316473", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5f43ecef028822fd3ca1134d8cc72703d5d11317573", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5f43ecef028822fd3ca1134d8cc72703d5d11318673", async() => {
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
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c5f43ecef028822fd3ca1134d8cc72703d5d11319773", async() => {
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
