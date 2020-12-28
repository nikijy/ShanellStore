using System;
using System.Collections.Generic;
using System.Text;
using ShanellStore.Core.DTOs.Product;
using ShanellStore.DataLayer.Entities.Product;

namespace ShanellStore.Core.Services.Interfaces
{
    public interface IProductService
    {
        #region MyRegion

        List<Category> GetAllCategories();
        Category GetCategoryById(int categoryId);
        bool InsertCategory(Category category);
        bool UpdateCategory(Category category);
        void DeleteCategory(Category category);
        void Save();

        #endregion

        #region product
        List<Product> GetAllProducts (int take = 0, int pageId = 1);
        Product GetProductById(int productId);
        bool InsertProduct(Product product);
        bool UpdateProduct(Product product);
        void DeleteProduct(Product product);

        IEnumerable<ProductViewModel> ShowProductByCategoryId(int categoryId, int take = 0, int pageId = 1);
        IEnumerable<ProductViewModel> ShowProductByBrandId(int brandId,int take = 0, int pageId = 1);
        IEnumerable<ProductViewModel> SearchProducts(string search);
        List<ProductBrand> GetAllProductBrands();
        List<ProductViewModel> ShowProductInHome(int take = 0, int pageId = 1);
        List<ProductViewModel> GetAllOfferedProduct(int take = 0, int pageId = 1);
        List<ProductViewModel> GetOfferedProducts(int take=4);
        int ProductCount();
        IEnumerable<Product> ProductPaging();


        #endregion


    }
}
