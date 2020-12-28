#pragma checksum "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e5b3d9c0fcea4b78f0f1a4c3af85e612ce9f3ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_EditRole), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/EditRole.cshtml")]
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
#line 1 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
using ShanellStore.DataLayer.Entities.Permission;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e5b3d9c0fcea4b78f0f1a4c3af85e612ce9f3ec9", @"/Areas/Admin/Views/Roles/EditRole.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Roles_EditRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShanellStore.DataLayer.Entities.User.Role>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "RoleTitle", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Roles", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
  
    ViewData["Title"] = "EditRole";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";
    List<Permission> permissions = ViewData["Permissions"] as List<Permission>;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e5b3d9c0fcea4b78f0f1a4c3af85e612ce9f3ec95776", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e5b3d9c0fcea4b78f0f1a4c3af85e612ce9f3ec96038", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 9 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <div class=\"col-md-8\">\r\n        <div class=\"form-group\">\r\n            <label>عنوان نقش</label>\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e5b3d9c0fcea4b78f0f1a4c3af85e612ce9f3ec97867", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 13 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.RoleTitle);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
        </div>
        <input type=""submit"" value=""ثبت"" class=""btn btn-success""/>
    </div>

    <div class=""col-md-4"">
        <div class=""panel panel-default"">
            <div class=""panel-heading"">
                <i class=""fa fa-adjust fa-fw""></i> مدیریت دسترسی ها
            </div>
            <!-- /.panel-heading -->
            <div class=""panel-body"">
");
#nullable restore
#line 25 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                  
                    List<int> SelectedPermissions = ViewData["SelectedPermissions"] as List<int>;
                

#line default
#line hidden
#nullable disable
                WriteLiteral("                <ul>\r\n");
#nullable restore
#line 29 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                     foreach (var permission in permissions.Where(p => p.ParentID == null))
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <li>\r\n                            <input type=\"checkbox\" name=\"SelectedPermission\" ");
#nullable restore
#line 32 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                         Write((SelectedPermissions.Any(p => p == permission.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" value=\"");
#nullable restore
#line 32 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                                                                                                                Write(permission.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" /> ");
#nullable restore
#line 32 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                                                                                                                                             Write(permission.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 34 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                             if (permissions.Any(p => p.ParentID == permission.ParentID))
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <ul>\r\n");
#nullable restore
#line 37 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                     foreach (var sub in permissions.Where(p => p.ParentID == permission.PermissionId))
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <li>\r\n                                            <input type=\"checkbox\" ");
#nullable restore
#line 40 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                               Write((SelectedPermissions.Any(p => p == sub.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
#nullable restore
#line 40 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                                                                                                                         Write(sub.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" /> ");
#nullable restore
#line 40 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                                                                                                                                               Write(sub.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 41 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                             if (permissions.Any(p => p.ParentID == sub.ParentID))
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <ul>\r\n\r\n");
#nullable restore
#line 45 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                     foreach (var sub2 in permissions.Where(p => p.ParentID == sub.PermissionId))
                                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                        <li>\r\n                                                            <input type=\"checkbox\" ");
#nullable restore
#line 48 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                               Write((SelectedPermissions.Any(p => p == sub2.PermissionId) ? "checked" : ""));

#line default
#line hidden
#nullable disable
                WriteLiteral(" name=\"SelectedPermission\" value=\"");
#nullable restore
#line 48 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                                                                                                                                          Write(sub2.PermissionId);

#line default
#line hidden
#nullable disable
                WriteLiteral("\" /> ");
#nullable restore
#line 48 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                                                                                                                                                                                 Write(sub2.PermissionTitle);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                                        </li>\r\n");
#nullable restore
#line 50 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                </ul>\r\n");
#nullable restore
#line 52 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        </li>\r\n");
#nullable restore
#line 54 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </ul>\r\n");
#nullable restore
#line 56 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </li>\r\n");
#nullable restore
#line 58 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Roles\EditRole.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </ul>\r\n            </div>\r\n            <!-- /.panel-body -->\r\n        </div>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Area = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShanellStore.DataLayer.Entities.User.Role> Html { get; private set; }
    }
}
#pragma warning restore 1591
