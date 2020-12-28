using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ShanellStore.Core.Security;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Context;
using ShanellStore.DataLayer.Entities.Product;

namespace ShanellStore.Web.Areas.Admin.Controllers
{
    [Authorize]
    [Area("Admin")]
    public class ProductsController : Controller
    {
        private readonly ShanellStoreContext _context;
        private IProductService _productService;

        public ProductsController(ShanellStoreContext context, IProductService productService)
        {
            _context = context;
            _productService = productService;
        }
        // GET: Admin/Products
      
        public async Task<IActionResult> Index(int pageId = 1)
        {
            int Count = _productService.ProductCount();
            ViewBag.count = Count;
            ViewBag.PageID = pageId;
            ViewBag.PageCount = Count / 12;

            return View(_productService.GetAllProducts(12,pageId));
        }

        // GET: Admin/Products/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // GET: Admin/Products/Create
      
        public IActionResult Create()
        {
            ViewData["CategoryId"] = new SelectList(_context.Categories.OrderBy(c=>c.Title), "CategoryId", "Title");
            ViewData["ProductBrandId"] = new SelectList(_context.ProductBrands.OrderBy(b=>b.BrandName), "ProductBrandId", "BrandName");
            ViewData["ProductColorId"] = new SelectList(_context.ProductColors.OrderBy(c=>c.Color), "ProductColorId", "Color");
            ViewData["ProductSizeId"] = new SelectList(_context.ProductSizes.OrderBy(s=>s.Size), "ProductSizeId", "Size");
            return View();
        }

        // POST: Admin/Products/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,CategoryId,ProductBrandId,ProductColorId,ProductSizeId,Price,IsAvailable,Name,ShortDescription,Description,ImageName,CreateDate,IsDeleted,DiscountPercent,DiscountedPrice,AvailableCount")] Product product,IFormFile image)
        {
            product.CreateDate = DateTime.Now;
            product.IsDeleted = false;
            product.IsAvailable = true;
            product.Visit = 0;
            product.DiscountedPrice =product.Price-(product.Price * product.DiscountPercent) / 100;
            if (ModelState.IsValid)
            {
              
                if (image != null && image.Length > 0)
                {
                    var fileName = Path.GetFileName(image.FileName);
                    var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\ProductImages", fileName);
                    await using (var fileSteam = new FileStream(filePath, FileMode.Create))
                    {
                        await image.CopyToAsync(fileSteam);
                    }
                    product.ImageName = fileName;
                }
                _context.Add(product);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Title", product.CategoryId);
            ViewData["ProductBrandId"] = new SelectList(_context.ProductBrands, "ProductBrandId", "BrandName", product.ProductBrandId);
            ViewData["ProductColorId"] = new SelectList(_context.ProductColors, "ProductColorId", "Color", product.ProductColorId);
            ViewData["ProductSizeId"] = new SelectList(_context.ProductSizes, "ProductSizeId", "Size", product.ProductSizeId);
            return View(product);
        }

        // GET: Admin/Products/Edit/5
      
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories.OrderBy(c => c.Title), "CategoryId", "Title", product.CategoryId);
            ViewData["ProductBrandId"] = new SelectList(_context.ProductBrands.OrderBy(c => c.BrandName), "ProductBrandId", "BrandName", product.ProductBrandId);
            ViewData["ProductColorId"] = new SelectList(_context.ProductColors.OrderBy(c => c.Color), "ProductColorId", "Color", product.ProductColorId);
            ViewData["ProductSizeId"] = new SelectList(_context.ProductSizes.OrderBy(c => c.Size), "ProductSizeId", "Size", product.ProductSizeId);
            return View(product);
        }

        // POST: Admin/Products/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,CategoryId,ProductBrandId,ProductColorId,ProductSizeId,Price,IsAvailable,Name,ShortDescription,Description,ImageName,CreateDate,IsDeleted,DiscountPercent,DiscountedPrice,AvailableCount")] Product product,IFormFile image)
        {
            if (id != product.ProductId)
            {
                return NotFound();
            }

            product.DiscountedPrice =product.Price-(product.Price * product.DiscountPercent) / 100;
            if (ModelState.IsValid)
            {
                try
                {

                    if (image != null && image.Length > 0)
                    {
                        var fileName = Path.GetFileName(image.FileName);
                        var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\ProductImages", fileName);
                        await using (var fileSteam = new FileStream(filePath, FileMode.Create))
                        {
                            await image.CopyToAsync(fileSteam);
                        }
                        product.ImageName = fileName;
                    }



                    _context.Update(product);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductExists(product.ProductId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["CategoryId"] = new SelectList(_context.Categories, "CategoryId", "Title", product.CategoryId);
            ViewData["ProductBrandId"] = new SelectList(_context.ProductBrands, "ProductBrandId", "BrandName", product.ProductBrandId);
            ViewData["ProductColorId"] = new SelectList(_context.ProductColors, "ProductColorId", "Color", product.ProductColorId);
            ViewData["ProductSizeId"] = new SelectList(_context.ProductSizes, "ProductSizeId", "Size", product.ProductSizeId);
            return View(product);
        }

        // GET: Admin/Products/Delete/5
       
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var product = await _context.Products
                .Include(p => p.Category)
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (product == null)
            {
                return NotFound();
            }

            return View(product);
        }

        // POST: Admin/Products/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var product = await _context.Products.FindAsync(id);
            product.IsDeleted =true;
            //_context.Products.Remove(product);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductExists(int id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
