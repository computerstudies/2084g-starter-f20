#pragma checksum "C:\eval\2084\f20-starter-tue\COMP2084BeerStore\Views\Store\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9cc659eb615ec80119e7471b6b2575cc6ceb7cd4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Store_Payment), @"mvc.1.0.view", @"/Views/Store/Payment.cshtml")]
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
#line 1 "C:\eval\2084\f20-starter-tue\COMP2084BeerStore\Views\_ViewImports.cshtml"
using COMP2084BeerStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\eval\2084\f20-starter-tue\COMP2084BeerStore\Views\_ViewImports.cshtml"
using COMP2084BeerStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9cc659eb615ec80119e7471b6b2575cc6ceb7cd4", @"/Views/Store/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca3feb71ac93fbe4edf33cff6dd2d1fd911a1872", @"/Views/_ViewImports.cshtml")]
    public class Views_Store_Payment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<h1>Payment</h1>\r\n\r\n<h4>Order Total: ");
#nullable restore
#line 3 "C:\eval\2084\f20-starter-tue\COMP2084BeerStore\Views\Store\Payment.cshtml"
            Write(String.Format("{0:c}", ViewBag.Total/100));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\r\n<script src=\"https://checkout.stripe.com/checkout.js\" class=\"stripe-button\"\r\n        data-key=\"");
#nullable restore
#line 6 "C:\eval\2084\f20-starter-tue\COMP2084BeerStore\Views\Store\Payment.cshtml"
             Write(ViewBag.PublishableKey);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n        data-amount=\"");
#nullable restore
#line 7 "C:\eval\2084\f20-starter-tue\COMP2084BeerStore\Views\Store\Payment.cshtml"
                Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n        data-name=\"COMP2084 Beer Store\"\r\n        data-image=\"https://stripe.com/img/documentation/checkout/marketplace.png\"\r\n        data-locale=\"auto\"\r\n        data-currency=\"cad\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591