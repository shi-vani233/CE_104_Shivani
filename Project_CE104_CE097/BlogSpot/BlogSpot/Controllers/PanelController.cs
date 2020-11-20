using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using BlogSpot.Data.FileManager;
using BlogSpot.Data.Repository;
using BlogSpot.Models;
using BlogSpot.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlogSpot.Controllers
{
    [Authorize(Roles ="Admin")]
    public class PanelController : Controller
    {
        private IRepository _repo;
        private IFileManager _fileManager;

        public PanelController(IRepository repo,IFileManager fileManager)
        {
            _repo = repo;
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            var blogs = _repo.GetAllBlogs();
            return View(blogs);
        }

        [HttpGet]
        public IActionResult AddBlog()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddBlog(BlogViewModel b)
        {
            if(b.Title==null || b.body==null || b.Image==null || b.Category==null)
            {
                ViewBag.Message = "Please,Fill All the fields!";
                return View();

            }
            var blog = new Blog
            {
                Blog_ID = b.Blog_ID,
                Title = b.Title,
                body = b.body,
                Category = b.Category,
                Image = await _fileManager.SaveImage(b.Image)
            };

            _repo.AddBlog(blog);

            if (await _repo.SaveChangesAsync())
            {
                TempData["Success"] = "Added Successfully!";
                return RedirectToAction("Index");
            }
            else
                return View(blog);

        }
 

        public IActionResult ViewBlog(int id)
        {
            var blog = _repo.GetBlog(id);
            return View(blog);
        }


    /*    [HttpGet("/Image/{image}")]
        public IActionResult Image(string image)
        {
            var mime = image.Substring(image.LastIndexOf('.') + 1);
            return new FileStreamResult(_fileManager.ImageStream(image), $"image/{mime}");
        }
*/

        [HttpGet]
        public IActionResult EditBlog(int? id)
        {
            if (id == null)
                return View(new BlogViewModel());
            else
            {
                var blog = _repo.GetBlog((int)id);
                return View(new BlogViewModel
                {
                    Blog_ID=blog.Blog_ID,
                    Title = blog.Title,
                    body = blog.body,
                    Category = blog.Category,
                });
            }

        }

        [HttpPost]
        public async Task<IActionResult> EditBlog(BlogViewModel b)
        {
            if (b.Title == null || b.body == null || b.Image == null || b.Category == null)
            {
                ViewBag.Message = "Please,Fill All the fields!";
                return View();
            }
            var blog = new Blog
            {
                Blog_ID = b.Blog_ID,
                Title = b.Title,
                body = b.body,
                Category = b.Category,
                Image = await _fileManager.SaveImage(b.Image)
            };
            if (blog.Blog_ID > 0)
            {
                _repo.UpdateBlog(blog);
            }
            else
            {
                _repo.AddBlog(blog);
            }
            if (await _repo.SaveChangesAsync())
            {
                TempData["Success"] = "Edited Successfully!";
                return RedirectToAction("Index");
            }
            else
                return View(blog);

        }




        [HttpGet]
        public async Task<IActionResult> RemoveBlog(int id)
        {
            _repo.RemoveBlog(id);
            await _repo.SaveChangesAsync();
            TempData["Success"] = "Removed Successfully!";
            return RedirectToAction("Index");
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
