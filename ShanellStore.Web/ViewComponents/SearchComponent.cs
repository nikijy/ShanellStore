using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShanellStore.Core.Services.Interfaces;

namespace ShanellStore.Web.ViewComponents
{
    public class SearchComponent:ViewComponent
    {
        private IProductService _productService;

        public SearchComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult((IViewComponentResult)View("_SearchProduct", _productService.GetAllCategories()));
        }
    }
}
