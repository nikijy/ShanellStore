#pragma checksum "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ff3230e37284a04c993a9bc13bd9f53fbdbcfeb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ff3230e37284a04c993a9bc13bd9f53fbdbcfeb", @"/Areas/Admin/Views/Products/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShanellStore.DataLayer.Entities.Product.Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>محصولات</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ff3230e37284a04c993a9bc13bd9f53fbdbcfeb4376", async() => {
                WriteLiteral("ایجاد محصول جدید");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductBrand.BrandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductColor.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductSize.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsAvailable));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.IsDeleted));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.DiscountedPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 56 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 60 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductBrand.BrandName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductColor.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductSize.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 74 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
             if (item.IsAvailable)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"text-success\">\r\n                    <i class=\"glyphicon glyphicon-ok\"></i>\r\n                </td>\r\n");
#nullable restore
#line 79 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"text-danger\">\r\n                    <i class=\"glyphicon glyphicon-remove\"></i>\r\n                </td>\r\n");
#nullable restore
#line 85 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 87 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2722, "\"", 2758, 2);
            WriteAttributeValue("", 2728, "/ProductImages/", 2728, 15, true);
#nullable restore
#line 91 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2743, item.ImageName, 2743, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"max-width: 100px\" class=\"thumbnail\" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreateDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 96 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
             if (item.IsDeleted == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"text-success\">\r\n                    <i class=\"glyphicon glyphicon-ok\"></i>\r\n                </td>\r\n");
#nullable restore
#line 101 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td class=\"text-danger\">\r\n                    <i class=\"glyphicon glyphicon-remove\"></i>\r\n                </td>\r\n");
#nullable restore
#line 107 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 109 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiscountPercent));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 112 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.DiscountedPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ff3230e37284a04c993a9bc13bd9f53fbdbcfeb15446", async() => {
                WriteLiteral("ویرایش ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 115 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                                       WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ff3230e37284a04c993a9bc13bd9f53fbdbcfeb17630", async() => {
                WriteLiteral("جزئیات ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 116 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                                          WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5ff3230e37284a04c993a9bc13bd9f53fbdbcfeb19817", async() => {
                WriteLiteral("حذف ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 117 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                                         WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 120 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 123 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
 if (ViewBag.count > 1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <nav>\r\n        <ul class=\"pagination\">\r\n");
#nullable restore
#line 127 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
             if (ViewBag.PageCount % 12 != 0)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 129 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                 for (int i = 1; i <= ((int) ViewBag.PageCount + 1); i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 4101, "\"", 4155, 1);
#nullable restore
#line 131 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 4109, ((int) ViewBag.PageID == i) ? "active" : "", 4109, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4177, "\"", 4215, 2);
            WriteAttributeValue("", 4184, "/Admin/Products/Index?pageId=", 4184, 29, true);
#nullable restore
#line 131 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 4213, i, 4213, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 131 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                                                                                                                                      Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 132 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 133 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                 
            }

            else
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 138 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                 for (int i = 1; i <= (int)ViewBag.PageCount; i++)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <li");
            BeginWriteAttribute("class", " class=\"", 4411, "\"", 4458, 1);
#nullable restore
#line 140 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 4419, ((int)ViewBag.PageID==i)?"active":"", 4419, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4480, "\"", 4518, 2);
            WriteAttributeValue("", 4487, "/Admin/Products/Index?pageId=", 4487, 29, true);
#nullable restore
#line 140 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 4516, i, 4516, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 140 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                                                                                                                               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 141 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"

                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 142 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
                 
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </ul>\r\n    </nav>\r\n");
#nullable restore
#line 146 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Areas\Admin\Views\Products\Index.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShanellStore.DataLayer.Entities.Product.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
