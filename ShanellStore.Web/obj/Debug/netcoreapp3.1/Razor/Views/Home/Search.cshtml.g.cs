#pragma checksum "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93d428cd7c151449a71e4e6b84d43d0d0e571471"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93d428cd7c151449a71e4e6b84d43d0d0e571471", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShanellStore.Core.DTOs.Product.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Home\Search.cshtml"
  
    ViewData["Title"] = "جستجو";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"w3ls_w3l_banner_nav_left_grid1\">\r\n        <h6>نتیجه جستجو</h6>\r\n");
#nullable restore
#line 10 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Home\Search.cshtml"
        foreach (var item in Model)
       {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"           <div class=""col-md-3 w3ls_w3l_banner_right"">
               <div class=""hover14 column"">
                   <div class=""agile_top_brand_right_grid w3l_agile_top_brand_right_grid"">
                       <div class=""agile_top_brand_right_grid_pos"">
                           <img src=""images/offer.png"" alt="" "" class=""img-responsive"">
                       </div>
                       <div class=""agile_top_brand_right_grid1"">
                           <figure>
                               <div class=""snipcart-item block"">
                                   <div class=""snipcart-thumb"">
                                       <a href=""single.html""><img");
            BeginWriteAttribute("src", " src=\"", 969, "\"", 1005, 2);
            WriteAttributeValue("", 975, "/ProductImages/", 975, 15, true);
#nullable restore
#line 22 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Home\Search.cshtml"
WriteAttributeValue("", 990, item.ImageName, 990, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\"></a>\r\n                                       <p>");
#nullable restore
#line 23 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Home\Search.cshtml"
                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                       <h4>$3.00 <span>");
#nullable restore
#line 24 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Home\Search.cshtml"
                                                  Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></h4>
                                   </div> 
                                   <div class=""snipcart-details"">
                                       <button class=""btn btn-danger my-cart-btn hvr-sweep-to-left"" data-id=""5"" data-name=""Knorr instant soup"" data-summary=""summary 5"" data-price=""3.00"" data-quantity=""1"" data-image=""images/5.png"">افزودن به سبد</button>
                                   </div>
                               </div>
                           </figure>
                       </div>
                   </div>
               </div>
           </div>
");
#nullable restore
#line 35 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Home\Search.cshtml"
       }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix\"> </div>\r\n    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ShanellStore.Core.DTOs.Product.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591