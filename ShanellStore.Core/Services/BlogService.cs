using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShanellStore.Core.DTOs.Blog;
using ShanellStore.Core.Services.Interfaces;
using ShanellStore.DataLayer.Context;
using ShanellStore.DataLayer.Entities.Blog;

namespace ShanellStore.Core.Services
{
   public class BlogService:IBlogService
   {
       private ShanellStoreContext _context;

       public BlogService(ShanellStoreContext context)
       {
           _context = context;
       }
        public IEnumerable<BlogViewModel> GetAllBlogs(int take = 0, int pageId = 1)
        {
            if (take == 0)
                take = 12;
            int skip = (pageId - 1) * take;
            return _context.Blogs.Include(b=>b.User)
                .Select(b=>new BlogViewModel()
            {
                BlogId = b.BlogId,
                UserName = b.User.UserName,
                ImageName = b.ImageName,
                ShortDescription = b.ShortDescription,
                CreateDate = b.CreateDate
            }).Skip(skip).Take(take).ToList();
        }

        public Blog GetBlogById(int blogId)
        {
            return _context.Blogs.Find(blogId);
        }

        public bool InsertBlog(Blog blog)
        {
            try
            {
                _context.Blogs.Add(blog);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateBlog(Blog blog)
        {
            try
            {
                _context.Blogs.Update(blog);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteBlog(Blog blog)
        {
            throw new NotImplementedException();
        }

        public int BlogCount()
        {
            return _context.Blogs.Count();
        }

        public void Save()
        {
            _context.SaveChanges();
        }

        public List<BlogComment> GetAllBlogComments()
        {
            throw new NotImplementedException();
        }

        public Blog GetBlogCommentById(int blogCommentId)
        {
            throw new NotImplementedException();
        }

        public bool InsertBlogComment(BlogComment blog)
        {
            try
            {
                _context.BlogComments.Add(blog);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public bool UpdateBlogComment(BlogComment blog)
        {
            try
            {
                _context.BlogComments.Update(blog);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public void DeleteBlogComment(BlogComment blog)
        {
            throw new NotImplementedException();
        }
    }
}
