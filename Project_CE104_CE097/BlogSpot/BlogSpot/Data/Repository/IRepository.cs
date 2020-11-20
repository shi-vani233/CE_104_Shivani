using BlogSpot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSpot.Models.Comments;

namespace BlogSpot.Data.Repository
{
    public interface IRepository
    {
        Blog GetBlog(int id);
        List<Blog> GetAllBlogs();
        void AddBlog(Blog blog);
        void UpdateBlog(Blog blog);
        void RemoveBlog(int id);
        void AddSubComment(SubComment comment);
        Task<bool> SaveChangesAsync();
        List<Blog> GetCatBlogs(string cat);
    }
}
