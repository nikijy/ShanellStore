using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShanellStore.Core.DTOs.Product;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Context;
using ShanellStore.DataLayer.Entities.Product;

namespace ShanellStore.Core.Services
{
    public class ProductService : IProductService
    {
        private ShanellStoreContext _context;

        public ProductService(ShanellStoreContext context)
        {
            _context = context;
        }
        public List<Category> GetAllCategories()
        {
            return _context.Categories.OrderBy(c=>c.Title).ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Categories.Find(categoryId);
        }

        public bool InsertCategory(Category category)
        {
            try
            {
                _context.Categories.Add(category);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateCategory(Category category)
        {
            try
            {
                _context.Categories.Update(category);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteCategory(Category category)
        {
            category.IsDeleted = true;
            UpdateCategory(category);

        }


        public void Save()
        {
            _context.SaveChanges();
        }

        public List<Product> GetAllProducts(int take = 0, int pageId = 1)
        {
            if (take == 0)
                take = 12;
            int skip = (pageId - 1) * take;
            return _context.Products
                .Include(c=>c.Category)
                .Include(b=>b.ProductBrand)
                .Include(s=>s.ProductSize)
                .Include(c=>c.ProductColor)
                .Where(p=>p.IsAvailable)
                .Skip(skip).Take(take)
                .ToList();
        }

        public Product GetProductById(int productId)
        {
            return _context.Products
                .Include(p=>p.ProductColor)
                .Include(c=>c.ProductBrand)
                .Include(s=>s.ProductSize)
                .Where(p => p.IsAvailable)
                .SingleOrDefault(p=>p.ProductId==productId);
        }

        public bool InsertProduct(Product product)
        {
            try
            {
                _context.Products.Add(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateProduct(Product product)
        {
            try
            {
                _context.Products.Update(product);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteProduct(Product product)
        {
            product.IsDeleted = true;
            UpdateProduct(product);
        }

        public IEnumerable<ProductViewModel> ShowProductByCategoryId(int categoryId, int take = 0, int pageId = 1)
        {

            if (take == 0)
                take = 12;
            int skip = (pageId - 1) * take;

            return _context.Products.Where(p => p.CategoryId == categoryId && p.IsAvailable)
                .Select(p=>new ProductViewModel()
                {
                    DiscountedPrice = p.DiscountedPrice,
                    ProductId = p.ProductId,
                    Name = p.Name,
                    ImageName = p.ImageName,
                    Price = p.Price
                }).Skip(skip).Take(take).ToList();
        }

        public IEnumerable<ProductViewModel> ShowProductByBrandId(int brandId, int take = 0, int pageId = 1)
        {

            if (take == 0)
                take = 12;
            int skip = (pageId - 1) * take;
            return _context.Products.Where(p => p.ProductBrandId == brandId&&p.IsAvailable)
                .Select(p => new ProductViewModel()
                {
                    DiscountedPrice = p.DiscountedPrice,
                    ProductId = p.ProductId,
                    Name = p.Name,
                    ImageName = p.ImageName,
                    Price = p.Price
                }).Skip(skip).Take(take).ToList();
        }

        public IEnumerable<ProductViewModel> SearchProducts(string search)
        {
            return _context.Products
                .Include(p=>p.ProductBrand)
                .Include(p=>p.ProductColor)
                .Include(p=>p.ProductSize)
               
                .Where(p => p.Name.Contains(search) && p.IsAvailable)

                .Select(p => new ProductViewModel()
                {
                    DiscountedPrice = p.DiscountedPrice,
                    ProductId = p.ProductId,
                    ImageName = p.ImageName,
                    Name = p.Name,
                    Price = p.Price
                })
                .ToList();
        }

        public List<ProductBrand> GetAllProductBrands()
        {
            return _context.ProductBrands.ToList();
        }

       

        public List<ProductViewModel> ShowProductInHome(int take = 0, int pageId = 1)
        {
            if (take == 0)
                take = 12;
            int skip = (pageId - 1) * take;

            return _context.Products.Where(p => p.IsAvailable)
                .OrderBy(p=>p.ProductId)
                .Select(p => new ProductViewModel()
            {
                DiscountedPrice = p.DiscountedPrice,
                ProductId = p.ProductId,
                Name = p.Name,
                ImageName = p.ImageName,
                Price = p.Price
            }).Skip(skip).Take(take).ToList();
        }

        public List<ProductViewModel> GetAllOfferedProduct(int take = 0, int pageId = 1)
        {

            if (take == 0)
                take = 12;
            int skip = (pageId - 1) * take;
            return _context.Products.Where(p => p.DiscountedPrice.Value != null && p.IsAvailable)
                .Select(p => new ProductViewModel()
                {
                    ProductId = p.ProductId,
                    DiscountedPrice = p.DiscountedPrice.Value,
                    Price = p.Price,
                    Name = p.Name,
                    ImageName = p.ImageName
                }).OrderByDescending(p=>p.DiscountedPrice).Skip(skip).Take(take).ToList();
        }

        public List<ProductViewModel> GetOfferedProducts(int take = 4)
        {
            return _context.Products.Where(p => p.DiscountedPrice.Value != null && p.IsAvailable)
                .Select(p => new ProductViewModel()
                {
                    ProductId = p.ProductId,
                    DiscountedPrice = p.DiscountedPrice.Value,
                    Price = p.Price,
                    Name = p.Name,
                    ImageName = p.ImageName
                }).Take(take).ToList();
        }

        public int ProductCount()
        {
            return _context.Products.Count();
        }

        public IEnumerable<Product> ProductPaging()
        {
            return _context.Products.OrderBy(p => p.ProductId);
        }
    }
}
