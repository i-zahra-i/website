#pragma checksum "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_ActiiveEmail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d05b8cf249e45e15e7751d00edd378d56d26195"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ActiiveEmail), @"mvc.1.0.view", @"/Views/Shared/_ActiiveEmail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_ActiiveEmail.cshtml", typeof(AspNetCore.Views_Shared__ActiiveEmail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d05b8cf249e45e15e7751d00edd378d56d26195", @"/Views/Shared/_ActiiveEmail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ActiiveEmail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Teacher4.DataLayer.Entities.User.User>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(46, 55, true);
            WriteLiteral("\r\n<div style=\"direction: rtl; padding: 20px\">\r\n    <h2>");
            EndContext();
            BeginContext(102, 14, false);
#line 4 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_ActiiveEmail.cshtml"
   Write(Model.UserName);

#line default
#line hidden
            EndContext();
            BeginContext(116, 133, true);
            WriteLiteral(" عزیز !</h2>\r\n    <p>با تشکر از ثبت نام شما در Teacher4 ، جهت ادامه کار میبایست حساب کاربری خود را فعال کنید</p>\r\n    <p>\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 249, "\"", 319, 2);
            WriteAttributeValue("", 256, "https://localhost:44385/Account/ActiveAccount/", 256, 46, true);
#line 7 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_ActiiveEmail.cshtml"
WriteAttributeValue("", 302, Model.ActiveCode, 302, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(320, 43, true);
            WriteLiteral(">فعالسازی حساب کاربری</a>\r\n    </p>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher4.DataLayer.Entities.User.User> Html { get; private set; }
    }
}
#pragma warning restore 1591
