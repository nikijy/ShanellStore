#pragma checksum "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c718a63ab3bb23251dc6dd66562553c0b77e6d23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowProductsByBrandId), @"mvc.1.0.view", @"/Views/Product/ShowProductsByBrandId.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c718a63ab3bb23251dc6dd66562553c0b77e6d23", @"/Views/Product/ShowProductsByBrandId.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowProductsByBrandId : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ShanellStore.Core.DTOs.Product.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
  
    ViewData["Title"] = "ShowProductsByBrandId";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""col-md-12"">
    <div class=""products-breadcrumb"">
        <div class=""container"">
            <ul>
                <li><i class=""fa fa-home"" aria-hidden=""true""></i><a href=""/Home/Index"">صفحه اصلی</a><span>|</span></li>
                <li>برندها</li>
            </ul>
        </div>
    </div>
</div>


<div class=""w3ls_w3l_banner_nav_left_grid"">
    <h3>لیست محصولات ما </h3>
    <div class=""w3ls_w3l_banner_nav_left_grid1"">
");
#nullable restore
#line 22 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col-md-3 w3ls_w3l_banner_right"">
                <div class=""hover14 column"">
                    <div class=""agile_top_brand_right_grid w3l_agile_top_brand_right_grid"">
                        <div class=""agile_top_brand_right_grid_pos"">
                        </div>
                        <div class=""agile_top_brand_right_grid1"">
                            <figure>
                                <div class=""snipcart-item block"">
                                    <div class=""snipcart-thumb"">
                                        <a");
            BeginWriteAttribute("href", " href=\"", 1257, "\"", 1294, 2);
            WriteAttributeValue("", 1264, "/ProductDetail/", 1264, 15, true);
#nullable restore
#line 33 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
WriteAttributeValue("", 1279, item.ProductId, 1279, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1300, "\"", 1336, 2);
            WriteAttributeValue("", 1306, "/ProductImages/", 1306, 15, true);
#nullable restore
#line 33 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
WriteAttributeValue("", 1321, item.ImageName, 1321, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\"></a>\r\n                                        <p>");
#nullable restore
#line 34 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 35 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                         if (item.DiscountedPrice != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h4>");
#nullable restore
#line 37 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                   Write(item.DiscountedPrice.Value.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 37 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                                                                     Write(item.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n");
#nullable restore
#line 38 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 41 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                             Write(item.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"snipcart-details\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2099, "\"", 2136, 2);
            WriteAttributeValue("", 2106, "/ProductDetail/", 2106, 15, true);
#nullable restore
#line 45 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
WriteAttributeValue("", 2121, item.ProductId, 2121, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""btn btn-danger my-cart-btn hvr-sweep-to-left"" data-id=""5"" data-name=""Knorr instant soup"" data-summary=""summary 5"" data-price=""3.00"" data-quantity=""1"" data-image=""images/5.png"">مشاهده</a>
                                    </div>
                                </div>
                            </figure>
                        </div>
                    </div>
                </div>
            </div>
");
#nullable restore
#line 53 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"clearfix\"> </div>\r\n    </div>\r\n");
#nullable restore
#line 56 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
     if (ViewBag.count > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav>\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 60 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                 if (ViewBag.PageCount % 12 != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 62 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                     for (int i = 1; i <= ((int) ViewBag.PageCount + 1); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 2909, "\"", 2963, 1);
#nullable restore
#line 64 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
WriteAttributeValue("", 2917, ((int) ViewBag.PageID == i) ? "active" : "", 2917, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 2985, "\"", 3032, 2);
            WriteAttributeValue("", 2992, "/Product/ShowProductsByBrandId?pageId=", 2992, 38, true);
#nullable restore
#line 64 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
WriteAttributeValue("", 3030, i, 3030, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 64 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                                                                                                                                   Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 65 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                     
                }

                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 71 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                     for (int i = 1; i <= (int)ViewBag.PageCount; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3256, "\"", 3303, 1);
#nullable restore
#line 73 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
WriteAttributeValue("", 3264, ((int)ViewBag.PageID==i)?"active":"", 3264, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3325, "\"", 3372, 2);
            WriteAttributeValue("", 3332, "/Product/ShowProductsByBrandId?pageId=", 3332, 38, true);
#nullable restore
#line 73 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
WriteAttributeValue("", 3370, i, 3370, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 73 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                                                                                                                                            Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 74 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 75 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
#nullable restore
#line 79 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowProductsByBrandId.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
