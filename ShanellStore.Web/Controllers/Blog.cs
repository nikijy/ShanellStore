using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShanellStore.Core.Services.Interfaces;

namespace ShanellStore.Web.Controllers
{
    public class Blog : Controller
    {
        private IBlogService _blogService;

        public Blog(IBlogService blogService)
        {
            _blogService = blogService;
        }
        [Route("Blog")]
        public IActionResult Index()
        {
            return View(_blogService.GetAllBlogs());
        }
        [Route("Blog/{id}")]
        public IActionResult ShowBlogSingle(int id)
        {
            var blogDetails = _blogService.GetBlogById(id);

            if (blogDetails == null)
            {
                return BadRequest();
            }

            blogDetails.Visit += 1;
            _blogService.UpdateBlog(blogDetails);
            _blogService.Save();

            return View(blogDetails);
        }

      
    }
}
