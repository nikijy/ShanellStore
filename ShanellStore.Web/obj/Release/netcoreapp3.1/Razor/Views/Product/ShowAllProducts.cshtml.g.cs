#pragma checksum "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7068397a2a8dc05cc3e02d5405ea47eb265cf3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ShowAllProducts), @"mvc.1.0.view", @"/Views/Product/ShowAllProducts.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7068397a2a8dc05cc3e02d5405ea47eb265cf3d", @"/Views/Product/ShowAllProducts.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ShowAllProducts : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShanellStore.Core.DTOs.Product.ProductViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
  
    ViewData["Title"] = "ShowAllProducts";
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
                <li>تمام محصولات</li>
            </ul>
        </div>
    </div>
</div>


<div class=""w3ls_w3l_banner_nav_left_grid"">
    <h3>لیست محصولات ما </h3>
    <div class=""w3ls_w3l_banner_nav_left_grid1"">
");
#nullable restore
#line 22 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
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
            BeginWriteAttribute("href", " href=\"", 1250, "\"", 1287, 2);
            WriteAttributeValue("", 1257, "/ProductDetail/", 1257, 15, true);
#nullable restore
#line 33 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 1272, item.ProductId, 1272, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><img");
            BeginWriteAttribute("src", " src=\"", 1293, "\"", 1329, 2);
            WriteAttributeValue("", 1299, "/ProductImages/", 1299, 15, true);
#nullable restore
#line 33 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 1314, item.ImageName, 1314, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\" \" class=\"img-responsive\"></a>\r\n                                        <p>");
#nullable restore
#line 34 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 35 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                         if (item.DiscountedPrice != null)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <h4>");
#nullable restore
#line 37 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                           Write(item.DiscountedPrice.Value.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" <span>");
#nullable restore
#line 37 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                                                                             Write(item.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></h4>\r\n");
#nullable restore
#line 38 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                        }
                                        else
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <span>");
#nullable restore
#line 41 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                             Write(item.Price.ToString("#,0"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 42 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </div>\r\n                                    <div class=\"snipcart-details\">\r\n                                        <a");
            BeginWriteAttribute("href", " href=\"", 2100, "\"", 2137, 2);
            WriteAttributeValue("", 2107, "/ProductDetail/", 2107, 15, true);
#nullable restore
#line 45 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 2122, item.ProductId, 2122, 15, false);

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
#line 53 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"clearfix\"> </div>\r\n    </div>\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 70 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
     if (ViewBag.count > 1)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <nav>\r\n            <ul class=\"pagination\">\r\n");
#nullable restore
#line 74 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                 if (ViewBag.PageCount % 12 != 0)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 76 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                     for (int i = 1; i <= ((int)ViewBag.PageCount + 1); i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3471, "\"", 3525, 1);
#nullable restore
#line 78 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 3479, ((int) ViewBag.PageID == i) ? "active" : "", 3479, 46, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3547, "\"", 3573, 2);
            WriteAttributeValue("", 3554, "/Products?pageId=", 3554, 17, true);
#nullable restore
#line 78 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 3571, i, 3571, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 79 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 80 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                     
                }

                else
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 85 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                     for (int i = 1; i <= (int)ViewBag.PageCount; i++)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li");
            BeginWriteAttribute("class", " class=\"", 3797, "\"", 3844, 1);
#nullable restore
#line 87 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 3805, ((int)ViewBag.PageID==i)?"active":"", 3805, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 3866, "\"", 3892, 2);
            WriteAttributeValue("", 3873, "/Products?pageId=", 3873, 17, true);
#nullable restore
#line 87 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
WriteAttributeValue("", 3890, i, 3890, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 87 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 88 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"

                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 89 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
                     
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </ul>\r\n        </nav>\r\n");
#nullable restore
#line 93 "F:\Shanell Store\ShanellStore\ShanellStore.Web\Views\Product\ShowAllProducts.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShanellStore.Core.DTOs.Product.ProductViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591