#pragma checksum "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e0312b768eb05dd64687ed22a3f15fce1118fe05"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_Roles_CreateRole), @"mvc.1.0.razor-page", @"/Pages/Admin/Roles/CreateRole.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/Roles/CreateRole.cshtml", typeof(AspNetCore.Pages_Admin_Roles_CreateRole), null)]
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
#line 2 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
using Teacher4.DataLayer.Entities.Permissions;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e0312b768eb05dd64687ed22a3f15fce1118fe05", @"/Pages/Admin/Roles/CreateRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_Roles_CreateRole : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "text", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn  btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 4 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
  
    ViewData["Title"] = "افزودن نقش";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
            BeginContext(237, 177, true);
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-lg-12\">\r\n        <h1 class=\"page-header\">افزودن نقش جدید</h1>\r\n    </div>\r\n    <!-- /.col-lg-12 -->\r\n</div>\r\n\r\n<div class=\"row\">\r\n    ");
            EndContext();
            BeginContext(414, 3178, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5008472fda1b4a4194d816c3b576f9e2", async() => {
                BeginContext(464, 379, true);
                WriteLiteral(@"
        <div class=""col-md-8"">
            <div class=""panel panel-primary"">
                <div class=""panel-heading"">
                    نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <div class=""form-group"">
                        <label>عنوان نقش</label>
                        ");
                EndContext();
                BeginContext(843, 65, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d6ce19bd15064fed8c732aa0b8a91d68", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 28 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Role.RoleTitle);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(908, 141, true);
                WriteLiteral("\r\n                    </div>\r\n                    <input type=\"submit\" value=\"ذخیره اطلاعات\" class=\"btn btn-success\" />\r\n                    ");
                EndContext();
                BeginContext(1049, 52, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ea181671bbb94dd38ab6800f5a90b7c3", async() => {
                    BeginContext(1091, 6, true);
                    WriteLiteral("انصراف");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1101, 395, true);
                WriteLiteral(@"
                </div>
                <!-- /.panel-body -->
            </div>
        </div>
        <div class=""col-md-4"">
            <div class=""panel panel-default"">
                <div class=""panel-heading"">
                    دسترسی های نقش
                </div>
                <!-- /.panel-heading -->
                <div class=""panel-body"">
                    <ul>
");
                EndContext();
#line 44 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                         foreach (var permission in permissions.Where(p => p.ParentID == null))
                        {

#line default
#line hidden
                BeginContext(1620, 114, true);
                WriteLiteral("                            <li>\r\n                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1734, "\"", 1766, 1);
#line 47 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 1742, permission.PermissionId, 1742, 24, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1767, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(1772, 26, false);
#line 47 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                Write(permission.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(1798, 4, true);
                WriteLiteral("\r\n\r\n");
                EndContext();
#line 49 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                 if (permissions.Any(p => p.ParentID == permission.ParentID))
                                {

#line default
#line hidden
                BeginContext(1932, 42, true);
                WriteLiteral("                                    <ul>\r\n");
                EndContext();
#line 52 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                         foreach (var sub in permissions.Where(p => p.ParentID == permission.PermissionId))
                                        {

#line default
#line hidden
                BeginContext(2142, 146, true);
                WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2288, "\"", 2313, 1);
#line 55 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2296, sub.PermissionId, 2296, 17, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2314, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(2319, 19, false);
#line 55 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                         Write(sub.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2338, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 56 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                 if (permissions.Any(p => p.ParentID == sub.ParentID))
                                                {

#line default
#line hidden
                BeginContext(2495, 60, true);
                WriteLiteral("                                                    <ul>\r\n\r\n");
                EndContext();
#line 60 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                         foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionId))
                                                        {

#line default
#line hidden
                BeginContext(2749, 178, true);
                WriteLiteral("                                                            <li>\r\n                                                                <input type=\"checkbox\" name=\"SelectedPermission\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 2927, "\"", 2953, 1);
#line 63 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
WriteAttributeValue("", 2935, sub2.PermissionId, 2935, 18, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2954, 4, true);
                WriteLiteral(" /> ");
                EndContext();
                BeginContext(2959, 20, false);
#line 63 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                                                                                                          Write(sub2.PermissionTitle);

#line default
#line hidden
                EndContext();
                BeginContext(2979, 69, true);
                WriteLiteral("\r\n                                                            </li>\r\n");
                EndContext();
#line 65 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                        }

#line default
#line hidden
                BeginContext(3107, 59, true);
                WriteLiteral("                                                    </ul>\r\n");
                EndContext();
#line 67 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                                }

#line default
#line hidden
                BeginContext(3217, 51, true);
                WriteLiteral("                                            </li>\r\n");
                EndContext();
#line 69 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                        }

#line default
#line hidden
                BeginContext(3311, 43, true);
                WriteLiteral("                                    </ul>\r\n");
                EndContext();
#line 71 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                                }

#line default
#line hidden
                BeginContext(3389, 35, true);
                WriteLiteral("                            </li>\r\n");
                EndContext();
#line 73 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\Roles\CreateRole.cshtml"
                        }

#line default
#line hidden
                BeginContext(3451, 134, true);
                WriteLiteral("                    </ul>\r\n                </div>\r\n                <!-- /.panel-body -->\r\n            </div>\r\n\r\n        </div>\r\n\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3592, 14, true);
            WriteLiteral("\r\n</div>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher4.Web.Pages.Admin.Roles.CreateRoleModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Teacher4.Web.Pages.Admin.Roles.CreateRoleModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Teacher4.Web.Pages.Admin.Roles.CreateRoleModel>)PageContext?.ViewData;
        public Teacher4.Web.Pages.Admin.Roles.CreateRoleModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591