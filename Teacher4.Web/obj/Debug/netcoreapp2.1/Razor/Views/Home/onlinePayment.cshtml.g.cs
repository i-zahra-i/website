#pragma checksum "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Home\onlinePayment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49047d3c25a148558732cf1d71fe324927292602"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_onlinePayment), @"mvc.1.0.view", @"/Views/Home/onlinePayment.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/onlinePayment.cshtml", typeof(AspNetCore.Views_Home_onlinePayment))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49047d3c25a148558732cf1d71fe324927292602", @"/Views/Home/onlinePayment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_onlinePayment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Home\onlinePayment.cshtml"
  
    ViewData["Title"] = "نتیجه پرداخت";
    Layout = "~/Views/Shared/_Account.cshtml";

#line default
#line hidden
            BeginContext(98, 58, true);
            WriteLiteral("<section class=\"section\">\r\n    <div class=\"container\">\r\n\r\n");
            EndContext();
#line 9 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Home\onlinePayment.cshtml"
         if (ViewBag.IsSuccess == true)
        {

#line default
#line hidden
            BeginContext(208, 144, true);
            WriteLiteral("            <div class=\"notification is-success is-light\">\r\n                <h2>پرداخت با موفقیت انجام شد</h2>\r\n                <p> کد پیگیری : ");
            EndContext();
            BeginContext(353, 12, false);
#line 13 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Home\onlinePayment.cshtml"
                           Write(ViewBag.Code);

#line default
#line hidden
            EndContext();
            BeginContext(365, 26, true);
            WriteLiteral("</p>\r\n            </div>\r\n");
            EndContext();
#line 15 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Home\onlinePayment.cshtml"
        }
        else
        {

#line default
#line hidden
            BeginContext(427, 131, true);
            WriteLiteral("            <div class=\"notification is-danger is-light\">\r\n                <h2>پرداخت با شکست مواجه شد</h2>\r\n\r\n            </div>\r\n");
            EndContext();
#line 22 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Home\onlinePayment.cshtml"
        }

#line default
#line hidden
            BeginContext(569, 26, true);
            WriteLiteral("    </div>\r\n</section>\r\n\r\n");
            EndContext();
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
