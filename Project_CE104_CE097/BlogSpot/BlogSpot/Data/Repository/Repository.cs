using BlogSpot.Models;
using BlogSpot.Models.Comments;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogSpot.Data.Repository
{
    public class Repository : IRepository
    {
        private AppDbContext _c;
       
        public Repository(AppDbContext c)
        {
            _c = c;
        }

        public void AddBlog(Blog blog)
        {
            _c.Blogs.Add(blog);
        }

        public List<Blog> GetAllBlogs()
        {
            return _c.Blogs.ToList();
        }

        public Blog GetBlog(int id)
        {
            return _c.Blogs
                .Include(b=>b.MainComments)
                .ThenInclude(mc=>mc.SubComments)
                .FirstOrDefault(b=>b.Blog_ID==id);
        }

        public void RemoveBlog(int id)
        {
            _c.Blogs.Remove(GetBlog(id));
        }

        public void UpdateBlog(Blog blog)
        {
            _c.Blogs.Update(blog);
        }
        public async Task<bool> SaveChangesAsync()
        {
            if (await _c.SaveChangesAsync() > 0)
            {
                return true;
            }
            return false;
        }

        public void AddSubComment(SubComment comment)
        {
            _c.SubComments.Add(comment);
        }
        public List<Blog> GetCatBlogs(string cat)
        {
            return _c.Blogs.Where(b => b.Category == cat).ToList();
        }
    }
}
