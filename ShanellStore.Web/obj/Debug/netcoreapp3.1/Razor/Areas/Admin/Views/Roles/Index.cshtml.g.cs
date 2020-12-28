#pragma checksum "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc0d45b7ac214e786f8ec5d72a4f3244610b8434"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc0d45b7ac214e786f8ec5d72a4f3244610b8434", @"/Areas/Admin/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShanellStore.DataLayer.Entities.User.Role>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""panel panel-default"">
        <div class=""panel-heading"">
            لیست نقش ها
        </div>
        <!-- /.panel-heading -->
        <a class=""btn btn-success"" href=""/Admin/Roles/CreateRole"">ایجاد نقش جدید</a>
        <div class=""panel-body"">
            <div class=""table-responsive"">
                <table class=""table table-striped"">
                    <thead>
                        <tr>
                            <th>عنوان نقش</th>
                            <th>دستورات</th>
                           
                        </tr>
                    </thead>
                    <tbody>
");
#nullable restore
#line 25 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\Index.cshtml"
                     foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 28 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\Index.cshtml"
                           Write(item.RoleTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1060, "\"", 1101, 2);
            WriteAttributeValue("", 1067, "/Admin/Roles/EditRole/", 1067, 22, true);
#nullable restore
#line 30 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1089, item.RoleId, 1089, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">ویرایش</a>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1173, "\"", 1216, 2);
            WriteAttributeValue("", 1180, "/Admin/Roles/DeleteRole/", 1180, 24, true);
#nullable restore
#line 31 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1204, item.RoleId, 1204, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">حذف</a>\r\n                            </td>\r\n                      \r\n                        </tr>\r\n");
#nullable restore
#line 35 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </tbody>\r\n                </table>\r\n            </div>\r\n            <!-- /.table-responsive -->\r\n        </div>\r\n        <!-- /.panel-body -->\r\n    </div>\r\n    <!-- /.panel -->\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShanellStore.DataLayer.Entities.User.Role>> Html { get; private set; }
    }
}
#pragma warning restore 1591