#pragma checksum "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e6d3c45a24315a39526104829df0159488ca37df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EmailTemplateForWelcome), @"mvc.1.0.view", @"/Views/Shared/EmailTemplateForWelcome.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6d3c45a24315a39526104829df0159488ca37df", @"/Views/Shared/EmailTemplateForWelcome.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b78c54896d7aeeecc3bee71d7bc8f7d42bebc3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_EmailTemplateForWelcome : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Email>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #f4f4f4; margin: 0 !important; padding: 0 !important;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
  
    var media = "media";
    var font = "font";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d3c45a24315a39526104829df0159488ca37df4618", async() => {
                WriteLiteral(@"
    <title></title>
    <meta http-equiv=""Content-Type"" content=""text/html; charset=utf-8"" />
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
    <style type=""text/css"">
        ");
#nullable restore
#line 14 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
   Write(media);

#line default
#line hidden
#nullable disable
                WriteLiteral(" screen {\r\n            ");
#nullable restore
#line 15 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
       Write(font);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"-face {
                font-family: 'Lato';
                font-style: normal;
                font-weight: 400;
                src: local('Lato Regular'), local('Lato-Regular'), url(https://fonts.gstatic.com/s/lato/v11/qIIYRU-oROkIk8vfvxw6QvesZW2xOQ-xsNqO47m55DA.woff) format('woff');
            }

            ");
#nullable restore
#line 22 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
       Write(font);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"-face {
                font-family: 'Lato';
                font-style: normal;
                font-weight: 700;
                src: local('Lato Bold'), local('Lato-Bold'), url(https://fonts.gstatic.com/s/lato/v11/qdgUG4U09HnJwhYI-uK18wLUuEpTyoUstqEm5AMlJo4.woff) format('woff');
            }

            ");
#nullable restore
#line 29 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
       Write(font);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"-face {
                font-family: 'Lato';
                font-style: italic;
                font-weight: 400;
                src: local('Lato Italic'), local('Lato-Italic'), url(https://fonts.gstatic.com/s/lato/v11/RYyZNoeFgb0l7W3Vu1aSWOvvDin1pK8aKteLpeZ5c0A.woff) format('woff');
            }

            ");
#nullable restore
#line 36 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
       Write(font);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"-face {
                font-family: 'Lato';
                font-style: italic;
                font-weight: 700;
                src: local('Lato Bold Italic'), local('Lato-BoldItalic'), url(https://fonts.gstatic.com/s/lato/v11/HkF_qI1x_noxlxhrhMQYELO3LdcAZYWl9Si6vvxL-qU.woff) format('woff');
            }
        }

        /* CLIENT-SPECIFIC STYLES */
        body,
        table,
        td,
        a {
            -webkit-text-size-adjust: 100%;
            -ms-text-size-adjust: 100%;
        }

        table,
        td {
            mso-table-lspace: 0pt;
            mso-table-rspace: 0pt;
        }

        img {
            -ms-interpolation-mode: bicubic;
        }

        /* RESET STYLES */
        img {
            border: 0;
            height: auto;
            line-height: 100%;
            outline: none;
            text-decoration: none;
        }

        table {
            border-collapse: collapse !important;
        }

        body {
            ");
                WriteLiteral(@"height: 100% !important;
            margin: 0 !important;
            padding: 0 !important;
            width: 100% !important;
        }

        /* iOS BLUE LINKS */
        a[x-apple-data-detectors] {
            color: inherit !important;
            text-decoration: none !important;
            font-size: inherit !important;
            font-family: inherit !important;
            font-weight: inherit !important;
            line-height: inherit !important;
        }

        /* MOBILE STYLES */
        ");
#nullable restore
#line 94 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
   Write(media);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" screen and (max-width:600px) {
            h1 {
                font-size: 32px !important;
                line-height: 32px !important;
            }
        }

        /* ANDROID CENTER FIX */
        div[style*=""margin: 16px 0;""] {
            margin: 0 !important;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6d3c45a24315a39526104829df0159488ca37df10297", async() => {
                WriteLiteral(@"
    <!-- HIDDEN PREHEADER TEXT -->
    <div style=""display: none; font-size: 1px; color: #fefefe; line-height: 1px; font-family: 'Lato', Helvetica, Arial, sans-serif; max-height: 0px; max-width: 0px; opacity: 0; overflow: hidden;""> We're thrilled to have you here! Get ready to dive into your new account. </div>
    <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"">
        <!-- LOGO -->
        <tr>
            <td bgcolor=""#FFA73B"" align=""center"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                    <tr>
                        <td align=""center"" valign=""top"" style=""padding: 40px 10px 40px 10px;""> </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor=""#FFA73B"" align=""center"" style=""padding: 0px 10px 0px 10px;"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                    ");
                WriteLiteral(@"<tr>
                        <td bgcolor=""#ffffff"" align=""center"" valign=""top"" style=""padding: 40px 20px 20px 20px; border-radius: 4px 4px 0px 0px; color: #111111; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 48px; font-weight: 400; letter-spacing: 4px; line-height: 48px;"">
                            <h1 style=""font-size: 48px; font-weight: 400; margin:2px;"">Welcome to StartUpSolution!</h1> <img src=""http://startupsolution.org.in/images/welcome.png"" width=""125"" height=""120"" style=""display: block; border: 0px;"" />
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor=""#f4f4f4"" align=""center"" style=""padding: 0px 10px 0px 10px;"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"" style=""padding: 20px 30px 40px 30px; color: #666666; font-family: 'Lato',");
                WriteLiteral(" Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;\">\r\n");
                WriteLiteral(@"                        </td>
                    </tr>
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"">
                            <table width=""100%"" border=""0"" cellspacing=""0"" cellpadding=""0"">
                                <tr>
                                    <td bgcolor=""#ffffff"" align=""center"" style=""padding: 20px 30px 60px 30px;"">
");
                WriteLiteral(@"                                    </td>
                                </tr>
                            </table>
                        </td>
                    </tr> <!-- COPY -->
                    <tr>
            <td bgcolor=""#ffffff"" align=""left"" style=""padding: 0px 30px 0px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;"">
                <p style=""margin: 0;"">Hi <span>");
#nullable restore
#line 158 "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Shared\EmailTemplateForWelcome.cshtml"
                                          Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(@" </span> , </p> <br />
                  <p style=""margin: 0;""> We are  glad to have you.</p><br />
                   <p style=""margin: 0;"">We will get back to you within 48hr. related to your quarry.</p>

            </td>
        </tr> 
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"" style=""padding: 0px 30px 20px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;"">
                            <p style=""margin: 0;"">We're always happy to help out.</p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"" style=""padding: 20px 30px 20px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;"">
                            <p style=""margin: 0;""><a href=""http://startupsolution.org.in/"" target=""_blank"" style=""color: #FFA73B;"">Go to WebSi");
                WriteLiteral(@"te</a></p>
                        </td>
                    </tr>
                    <tr>
                        <td bgcolor=""#ffffff"" align=""left"" style=""padding: 0px 30px 40px 30px; border-radius: 0px 0px 4px 4px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-height: 25px;"">
                            <p style=""margin: 0;"">Cheers,<br>StartUpSolution Team</p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor=""#f4f4f4"" align=""center"" style=""padding: 30px 10px 0px 10px;"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                    <tr>
                        <td bgcolor=""#FFECD1"" align=""center"" style=""padding: 30px 30px 30px 30px; border-radius: 4px 4px 4px 4px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 18px; font-weight: 400; line-");
                WriteLiteral(@"height: 25px;"">
                            <h2 style=""font-size: 20px; font-weight: 400; color: #111111; margin: 0;"">Need more help?</h2>
                            <p style=""margin: 0;""><a href=""http://startupsolution.org.in/Contact"" target=""_blank"" style=""color: #FFA73B;"">We&rsquo;re here to help you out</a></p>
                        </td>
                    </tr>
                </table>
            </td>
        </tr>
        <tr>
            <td bgcolor=""#f4f4f4"" align=""center"" style=""padding: 0px 10px 0px 10px;"">
                <table border=""0"" cellpadding=""0"" cellspacing=""0"" width=""100%"" style=""max-width: 600px;"">
                    <tr>
                        <td bgcolor=""#f4f4f4"" align=""left"" style=""padding: 0px 30px 30px 30px; color: #666666; font-family: 'Lato', Helvetica, Arial, sans-serif; font-size: 14px; font-weight: 400; line-height: 18px;"">
                            <br>
");
                WriteLiteral("                        </td>\r\n                    </tr>\r\n                </table>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Email> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
