#pragma checksum "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94298513db3d8ec826a005523e6ce70505921f84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Home), @"mvc.1.0.view", @"/Views/Shared/_Home.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Home.cshtml", typeof(AspNetCore.Views_Shared__Home))]
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
#line 1 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
using Teacher4.Core.Convertors;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94298513db3d8ec826a005523e6ce70505921f84", @"/Views/Shared/_Home.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Home : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Course"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Footer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 27, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n\r\n");
            EndContext();
            BeginContext(60, 826, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cdbb5e81bffa469196aafe4e44675d21", async() => {
                BeginContext(66, 813, true);
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""shortcut icon"" type=""image/png"" href=""/Image/iconTeacher4.png"" sizes=""128x128"">
    <title>???????? ????????????</title>
    <!--<link rel=""stylesheet"" href=""/Css/Bulma/css/bulma.min.css"">
    <link rel=""stylesheet"" href=""/Css/all.min.css"">-->
    <link rel=""stylesheet"" href=""  https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.3/css/all.min.css"">
    <link rel=""stylesheet"" href=""https://cdn.jsdelivr.net/npm/bulma@0.9.2/css/bulma.min.css"">
    <link rel=""stylesheet"" href=""/Css/home.css"">
    <link rel=""stylesheet"" href=""/Css/owl.carousel.min.css"">
    <link rel=""stylesheet"" type=""text/css"" href=""/Css/MainMenu.css"">

    <!--<link rel=""stylesheet"" href=""/Bulma/css/debug.css"">-->
");
                EndContext();
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
            EndContext();
            BeginContext(886, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(888, 4893, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ac635eded4440a3a2260337c7d3fdfe", async() => {
                BeginContext(894, 1447, true);
                WriteLiteral(@"
    <!------------------------------  Start Top Menu  ---------------------------->
    <section>
        <div class=""top-menu"">
            <div class=""container"">
                <nav class=""level is-mobile"">
                    <!-- Left side -->
                    <div class=""level-left is-mobile"">
                        <p class=""level-item"">
                            <a class="" navbar-item is-size-5-desktop "" id=""search"">
                                <span class=""icon"">
                                    <i class=""fas fa-search""></i>
                                </span>
                            </a>
                        </p>
                        <p class=""level-item"">
                            <a class=""navbar-item is-size-5-desktop"" href=""#footer"">
                                <span class=""icon""><i class=""fas fa-info""></i></span>
                            </a>
                        </p>
                        <p class=""level-item"">
                   ");
                WriteLiteral(@"         <a class=""navbar-item is-size-5-desktop"" href=""#footer"">
                                <span class=""icon"">
                                    <i class=""fas fa-phone-alt""></i>
                                </span>
                            </a>
                        </p>
                    </div>
                    <!-- Right side -->
                    <div class=""level-right is-mobile"">

");
                EndContext();
#line 51 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
                         if (User.Identity.IsAuthenticated)
                        {

#line default
#line hidden
                BeginContext(2429, 166, true);
                WriteLiteral("                            <div class=\"level-item\">\r\n                                <a href=\"/UserPanel\" class=\"navbar-item \">\r\n                                    ");
                EndContext();
                BeginContext(2596, 18, false);
#line 55 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
                               Write(User.Identity.Name);

#line default
#line hidden
                EndContext();
                BeginContext(2614, 87, true);
                WriteLiteral(" ?? ?????? ????????\r\n                                </a>\r\n                            </div>\r\n");
                EndContext();
#line 58 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
                        }
                        else
                        {

#line default
#line hidden
                BeginContext(2785, 488, true);
                WriteLiteral(@"                            <div class=""level-item"">
                                <a href=""/Login"" class=""navbar-item "">
                                    ????????
                                </a>
                            </div>
                            <div class=""level-item"">
                                <a href=""/Register"" class=""navbar-item "">
                                    ??????????
                                </a>
                            </div>
");
                EndContext();
#line 71 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"

                        }

#line default
#line hidden
                BeginContext(3302, 398, true);
                WriteLiteral(@"                        <div class=""level-item"">
                            <a href=""/"" class=""navbar-item "">
                                ????????
                            </a>
                        </div>
                    </div>
                </nav>

            </div>
            <div class=""container field"" id=""divSearch"" style=""display: ltr !important;"">
                ");
                EndContext();
                BeginContext(3700, 441, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d4dc5cdebf4e4c8fb48ce680dea5b5c4", async() => {
                    BeginContext(3736, 398, true);
                    WriteLiteral(@"
                    <p class=""control has-icons-left"">
                        <input name=""filter"" class=""input is-warning is-hovered is-rounded has-text-right"" type=""text"" placeholder=""...??????????"">
                        <span class=""icon is-small is-left"">
                            <i class=""fas fa-search""></i>
                        </span>
                    </p>
                ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4141, 437, true);
                WriteLiteral(@"
            </div>
        </div>
    </section>
    <div class=""my5""><br></div>
    <!--------------------------   Start Header   ---------------------------->
    <header class=""is-fullwidth header "">
        <figure>
            <img src=""/Image/header_teacher.png"" alt=""header"">
        </figure>
        <div class=""is-size-7-touch is-size-4 has-text-info-dark has-text-weight-bold has-text-left"">

            <span>
");
                EndContext();
#line 103 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
                  string date = DateTime.Now.ToShamsi().ToString();

#line default
#line hidden
                BeginContext(4648, 16, true);
                WriteLiteral("                ");
                EndContext();
                BeginContext(4665, 4, false);
#line 104 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
           Write(date);

#line default
#line hidden
                EndContext();
                BeginContext(4669, 141, true);
                WriteLiteral("\r\n            </span>\r\n        </div>\r\n\r\n    </header>\r\n    <!---------------------------  Start Main Menu  -------------------------->\r\n    ");
                EndContext();
                BeginContext(4811, 51, false);
#line 110 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
Write(await Component.InvokeAsync("CourseGroupComponent"));

#line default
#line hidden
                EndContext();
                BeginContext(4862, 265, true);
                WriteLiteral(@"
    <!------------------------------  Start Body  ---------------------------->
    <section class=""section"">
        <div class=""container"">
            <div class=""columns body  is-variable "">
                <div class=""column is-12"">
                    ");
                EndContext();
                BeginContext(5128, 12, false);
#line 116 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Views\Shared\_Home.cshtml"
               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(5140, 167, true);
                WriteLiteral("\r\n\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n    <!------------------------------  Start Footer  ---------------------------->\r\n    ");
                EndContext();
                BeginContext(5307, 26, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "71bf47c473f6498398645194b92a77de", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5333, 441, true);
                WriteLiteral(@"

    <!------------------------------  Start Script  ---------------------------->
    <script src=""https://code.jquery.com/jquery-3.6.0.js"" integrity=""sha256-H+K7U5CnXl1h5ywQfKtSj8PCmoN9aaq30gDh27Xc0jk=""
            crossorigin=""anonymous""></script>
    <script src=""/Js/owl.carousel.min.js""></script>
    <script src=""/Js/Index.js""></script>
    <script src=""/Js/Style.js""></script>
    <script src=""/Js/MainMenu.js""></script>

");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5781, 9, true);
            WriteLiteral("\r\n</html>");
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
