#pragma checksum "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Shared\Components\FooterCategoryComponent\_categoryFooter.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc39ca1f4ce797a6798e91ab9484b4df1cfc62d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_FooterCategoryComponent__categoryFooter), @"mvc.1.0.view", @"/Views/Shared/Components/FooterCategoryComponent/_categoryFooter.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc39ca1f4ce797a6798e91ab9484b4df1cfc62d", @"/Views/Shared/Components/FooterCategoryComponent/_categoryFooter.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_FooterCategoryComponent__categoryFooter : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShanellStore.DataLayer.Entities.Product.Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<ul class=\"w3_footer_grid_list\">\r\n");
#nullable restore
#line 4 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Shared\Components\FooterCategoryComponent\_categoryFooter.cshtml"
    foreach (var item in Model)
   {

#line default
#line hidden
#nullable disable
            WriteLiteral("       <li>\r\n           <a");
            BeginWriteAttribute("href", " href=\"", 171, "\"", 228, 2);
            WriteAttributeValue("", 178, "/Product/ShowProductsByCategoryId/", 178, 34, true);
#nullable restore
#line 7 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Shared\Components\FooterCategoryComponent\_categoryFooter.cshtml"
WriteAttributeValue("", 212, item.CategoryId, 212, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n               ");
#nullable restore
#line 8 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Shared\Components\FooterCategoryComponent\_categoryFooter.cshtml"
          Write(item.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n           </a>\r\n       </li>\r\n");
#nullable restore
#line 11 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Shared\Components\FooterCategoryComponent\_categoryFooter.cshtml"
   
   }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShanellStore.DataLayer.Entities.Product.Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591