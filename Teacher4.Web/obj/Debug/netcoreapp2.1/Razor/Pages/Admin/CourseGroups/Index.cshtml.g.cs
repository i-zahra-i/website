#pragma checksum "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d15902a89ddcd83e43d47f10e82dd9cdb71af039"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Admin_CourseGroups_Index), @"mvc.1.0.razor-page", @"/Pages/Admin/CourseGroups/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Admin/CourseGroups/Index.cshtml", typeof(AspNetCore.Pages_Admin_CourseGroups_Index), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d15902a89ddcd83e43d47f10e82dd9cdb71af039", @"/Pages/Admin/CourseGroups/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Admin_CourseGroups_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "CreateGroup", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-outline btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Pages/Shared/_AdminLayout.cshtml";

#line default
#line hidden
            BeginContext(157, 673, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12"">
        <h1 class=""page-header"">لیست گروه  ها</h1>
    </div>
    <!-- /.col-lg-12 -->
</div>

<div class=""row"">
    <div class=""col-lg-12"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                لیست گروه های سایت
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
                <div class=""table-responsive"">
                    <div id=""dataTables-example_wrapper"" class=""dataTables_wrapper form-inline"" role=""grid"">
                        <div class=""col-md-12"" style=""margin: 10px 0;"">

                            ");
            EndContext();
            BeginContext(830, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5294d070815649e39179f140619a3042", async() => {
                BeginContext(892, 16, true);
                WriteLiteral("افزودن گروه جدید");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(912, 569, true);
            WriteLiteral(@"

                        </div>
                        <table class=""table table-striped table-bordered table-hover dataTable no-footer"" id=""dataTables-example"" aria-describedby=""dataTables-example_info"">
                            <thead>
                                <tr>
                                    <th>عنوان گروه</th>
                                    <th>زیر گروه ها</th>
                                    <th>دستورات</th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 38 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                 foreach (var group in Model.CourseGroups.Where(g=>g.ParentId==null))
                                {

#line default
#line hidden
            BeginContext(1619, 78, true);
            WriteLiteral("                                <tr>\r\n                                    <td>");
            EndContext();
            BeginContext(1698, 16, false);
#line 41 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                   Write(group.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 49, true);
            WriteLiteral("</td>\r\n                                    <td>\r\n");
            EndContext();
#line 43 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                         if (group.CourseGroups.Any())
                                            {

#line default
#line hidden
            BeginContext(1882, 46, true);
            WriteLiteral("                                        <ul>\r\n");
            EndContext();
#line 46 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                             foreach (var sub in group.CourseGroups)
                                                    {

#line default
#line hidden
            BeginContext(2069, 100, true);
            WriteLiteral("                                            <li>\r\n                                                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2169, "\"", 2218, 2);
            WriteAttributeValue("", 2176, "/Admin/CourseGroups/EditGroup/", 2176, 30, true);
#line 49 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2206, sub.GroupId, 2206, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2219, 148, true);
            WriteLiteral(" class=\"btn btn-dark btn-xs\">\r\n                                                    ویرایش\r\n                                                </a> --- ");
            EndContext();
            BeginContext(2368, 14, false);
#line 51 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                    Write(sub.GroupTitle);

#line default
#line hidden
            EndContext();
            BeginContext(2382, 53, true);
            WriteLiteral("\r\n                                            </li>\r\n");
            EndContext();
#line 53 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                                    }

#line default
#line hidden
            BeginContext(2490, 47, true);
            WriteLiteral("                                        </ul>\r\n");
            EndContext();
#line 55 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                            }

#line default
#line hidden
            BeginContext(2584, 127, true);
            WriteLiteral("                                    </td>\r\n                                    <td>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2711, "\"", 2764, 2);
            WriteAttributeValue("", 2718, "/Admin/CourseGroups/CreateGroup/", 2718, 32, true);
#line 58 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2750, group.GroupId, 2750, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2765, 173, true);
            WriteLiteral(" class=\"btn btn-info btn-sm\">\r\n                                            زیر گروه\r\n                                        </a>\r\n                                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2938, "\"", 2989, 2);
            WriteAttributeValue("", 2945, "/Admin/CourseGroups/EditGroup/", 2945, 30, true);
#line 61 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
WriteAttributeValue("", 2975, group.GroupId, 2975, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2990, 214, true);
            WriteLiteral(" class=\"btn btn-warning btn-sm\">\r\n                                            ویرایش\r\n                                        </a>\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 66 "F:\project\Main\MyAcademicNET3\Back\Teacher4Core\Teacher4.Web\Pages\Admin\CourseGroups\Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(3239, 269, true);
            WriteLiteral(@"                            </tbody>
                        </table>
                    </div>
                </div>

            </div>
            <!-- /.panel-body -->
        </div>
        <!-- /.panel -->
    </div>
    <!-- /.col-lg-12 -->
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Teacher4.Web.Pages.Admin.CourseGroups.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Teacher4.Web.Pages.Admin.CourseGroups.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Teacher4.Web.Pages.Admin.CourseGroups.IndexModel>)PageContext?.ViewData;
        public Teacher4.Web.Pages.Admin.CourseGroups.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
