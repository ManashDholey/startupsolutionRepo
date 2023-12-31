#pragma checksum "E:\Accounts\PriceOptimizerCoreApplication\PriceOptimizerCoreApplication.web\Views\Home\_PartialPriceAndPlans.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e888105d0070a21fd3e7a94ffbbf10a72201230"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home__PartialPriceAndPlans), @"mvc.1.0.view", @"/Views/Home/_PartialPriceAndPlans.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e888105d0070a21fd3e7a94ffbbf10a72201230", @"/Views/Home/_PartialPriceAndPlans.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"10b78c54896d7aeeecc3bee71d7bc8f7d42bebc3", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home__PartialPriceAndPlans : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<section class=""ftco-section bg-light"">
    <div class=""container"">
        <div class=""row justify-content-center pb-5 mb-3"">
            <div class=""col-md-7 heading-section text-center ftco-animate"">
                <span class=""subheading"">Price &amp; Plans</span>
                <h2>Affordable Packages</h2>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                
                <div class=""block-7"">
                    <div class=""container"">
                        
                                    <div class=""text-center"">
                                        <span class=""excerpt d-block"">Personal</span>
                                        <span class=""price""> <span class=""numberone""> Starts from only <sup class=""icon icon-rs"">₹</sup> 999 </span> <sub class=""icon icon-rs"">/Yr </sub></span>
                                        <ul class=""pricing-text mb-5"">
                                     ");
            WriteLiteral(@"       <li><span class=""fa fa-check mr-2""></span>Returns for Salaried person</li>
                                            <li><span class=""fa fa-check mr-2""></span>Returns for Capital Gain</li>
                                            <li><span class=""fa fa-check mr-2""></span>Returns with one House Property</li>
                                            <li><span class=""fa fa-check mr-2""></span>Investment Consultation</li>
                                            <li><span class=""fa fa-check mr-2""></span>Tax Savings Plan</li>
                                        </ul>
                                        <a href=""#"" class=""btn btn-primary d-block px-2 py-3"" data-toggle=""modal""   data-backdrop=""static"" data-keyboard=""false"" onclick=""GetHtmlPersonal(this);"" data-type=""Personal"">Get Started</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                <div class=""block-");
            WriteLiteral(@"7"">
                    <div class=""container"">
                                    <div class=""text-center"">
                                        <span class=""excerpt d-block"">Small Business</span>
                                        <span class=""price""> <span class=""numberone"">Starts from only <sup class=""icon icon-rs"">₹</sup> 1499</span> <sub class=""icon icon-rs"">/Yr</sub></span>

                                        <ul class=""pricing-text mb-5"">
                                            <li><span class=""fa fa-check mr-2""></span>Yearly Return</li>
                                            <li><span class=""fa fa-check mr-2""></span>Final A/c</li>
                                            <li><span class=""fa fa-check mr-2""></span>Balance Sheet</li>
                                            <li><span class=""fa fa-check mr-2""></span>Investment Consultation</li>
                                            <li><span class=""fa fa-check mr-2""></span>Tax Savings Plan</li>
             ");
            WriteLiteral(@"                               &nbsp;
                                            <li></li>
                                            &nbsp;
                                            <li></li>
                                        </ul>
                                        <a href=""#"" class=""btn btn-primary d-block px-2 py-3""  data-toggle=""modal""   data-backdrop=""static"" data-keyboard=""false"" onclick=""GetHtmlPersonal(this);""  data-type=""Small Business"">Get Started</a>
                                   
                        </div>
                    </div>
                </div>

            </div>
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                <div class=""block-7"">
                    <div class=""container"">
                        
                                    <div class=""text-center"">
                                        <span class=""excerpt d-block"">Monthly Accounting</span>
                                        <span class=""price""> <spa");
            WriteLiteral("n class=\"numberone\">Starts from only <sup class=\"icon icon-rs\">₹</sup>1999</span> <sub class=\"icon icon-rs\">/mos</sub></span>\r\n");
            WriteLiteral(@"
                                    <ul class=""pricing-text mb-5"">
                                        <li><span class=""fa fa-check mr-2""></span>Sale Entry</li>
                                        <li><span class=""fa fa-check mr-2""></span>Purchase Entry</li>
                                        <li><span class=""fa fa-check mr-2""></span>Cash Entry</li>
                                        <li><span class=""fa fa-check mr-2""></span>Bank Entry</li>
                                        <li><span class=""fa fa-check mr-2""></span>MIS Reports</li>
                                        &nbsp;
                                        <li></li>
                                        &nbsp;
                                        <li></li>
                                    </ul>

                                        <a href=""#"" class=""btn btn-primary d-block px-2 py-3""  data-toggle=""modal""   data-backdrop=""static"" data-keyboard=""false"" onclick=""GetHtmlPersonal(this);""   data-type=""Mon");
            WriteLiteral(@"thly Accounting"">Get Started</a>
                                   
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-lg-3 ftco-animate"">
                <div class=""block-7"">
                    <div class=""container"">
                       
                                    <div class=""text-center"">
                                        <span class=""excerpt d-block"">Payroll</span>
                                        <span class=""price""> <span class=""numberone"">Starts from only <sup class=""icon icon-rs"">₹</sup>1499</span> <sub class=""icon icon-rs"">/mos</sub></span>

                                        <ul class=""pricing-text mb-5"">
                                            <li><span class=""fa fa-check mr-2""></span>Calculation of Salary</li>
                                            <li><span class=""fa fa-check mr-2""></span>Calculation of PF & ESIC</li>
                                    ");
            WriteLiteral(@"        <li><span class=""fa fa-check mr-2""></span>Arrangement for Disbursement of Salary</li>
                                            <li><span class=""fa fa-check mr-2""></span>PF & ESIC Returns</li>
                                            <li><span class=""fa fa-check mr-2""></span>TDS & TCS Returns</li>
                                            <li></li>
                                            <li></li>
                                            <li></li>
                                        </ul>

                                        <a href=""#"" class=""btn btn-primary d-block px-2 py-3""  data-toggle=""modal""   data-backdrop=""static"" data-keyboard=""false"" onclick=""GetHtmlPersonal(this);""  data-type=""Payroll"">Get Started</a>
                                   
                        </div>
                    </div>
                </div>

            </div>
        </div>
    </div>
</section>

");
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
