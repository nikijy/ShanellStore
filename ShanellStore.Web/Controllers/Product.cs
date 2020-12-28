 using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Context;
 using ZarinpalSandbox;

 namespace ShanellStore.Web.Controllers
{
    public class Product : Controller
    {
        private IProductService productService;
        private ShanellStoreContext _context;
        private IOrderService _orderService;

        public Product(IProductService productService, ShanellStoreContext context, IOrderService orderService)
        {
            this.productService = productService;
            _context = context;
            _orderService = orderService;
        }
        public IActionResult Index(int pageId=1)
        {
            int Count = productService.ProductCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;

            return View(productService.ShowProductInHome(12,pageId));
        }

        [Route("Products/{pageId?}")]
        public IActionResult ShowAllProducts(int pageId=1)
        {
            int Count = productService.ProductCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;

            var list = productService.ShowProductInHome(12,pageId);
            return View(list);

           // return View(productService.ShowProductInHome());
        }
        [Route("OfferedProducts/{pageId?}")]
        public IActionResult GetAllOfferedProducts(int pageId=1)
        {
            int Count = productService.ProductCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;
            return View(productService.GetAllOfferedProduct(12,pageId));
        }
       // [Route("Category/{id}/{title}")]
        public IActionResult ShowProductsByCategoryId(int id, string title,int pageId=1)
        {
            int Count = productService.ProductCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;
            ViewBag.title = title;
            return View(productService.ShowProductByCategoryId(id,12,pageId));
        }

        public IActionResult ShowProductsByBrandId(int id, string title,int pageId= 1)
        {
            int Count = productService.ProductCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;
            ViewBag.title = title;
            return View(productService.ShowProductByBrandId(id,12,pageId));
        }

        [Route("ProductDetail/{id}")]
        public IActionResult ShowProductSingle(int id)
        {
            var productDetail = productService.GetProductById(id);
            //ViewData["ProductBrandId"] = new SelectList(_context.ProductBrands, "ProductBrandId", "BrandName");
            //ViewData["ProductColorId"] = new SelectList(_context.ProductColors, "ProductColorId", "Color");
            //ViewData["ProductSizeId"] = new SelectList(_context.ProductSizes, "ProductSizeId", "Size");

            if (productDetail == null)
            {
                return BadRequest();
            }

            productDetail.Visit += 1;
            productService.UpdateProduct(productDetail);
            productService.Save();

            return View(productDetail);
        }

    }
}
