using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BlogSpot.Models;
using BlogSpot.Data;
using BlogSpot.Data.Repository;
using BlogSpot.Data.FileManager;
using BlogSpot.ViewModels;
using BlogSpot.Models.Comments;

namespace BlogSpot.Controllers
{
    public class HomeController : Controller
    {
        private IRepository _repo;
        private readonly ILogger<HomeController> _logger;
        private readonly IFileManager _fileManager;

        public HomeController(IRepository repo, ILogger<HomeController> logger, IFileManager fileManager)
        {
            _repo = repo;
            _logger = logger;
            _fileManager = fileManager;
        }


        public IActionResult Index()
        {
            var blogs = _repo.GetAllBlogs();
            return View(blogs);
        }
        public IActionResult ViewBlog(int id)
        {
            var blog = _repo.GetBlog(id);
            return View(blog);
        }

          [HttpGet("/Image/{image}")]
          public IActionResult Image(string image)
          {
              var mime= image.Substring(image.LastIndexOf('.')+1);
              return new FileStreamResult(_fileManager.ImageStream(image),$"image/{mime}");
          }

        public IActionResult Category(string category)
        {
            var blogs = _repo.GetCatBlogs(category);
            ViewBag.c=category;
            return View(blogs);
        }

        [HttpPost]
        public async Task<IActionResult> Comment(CommentViewModel vm)
        {
            if (!ModelState.IsValid)
                return RedirectToAction("ViewBlog",new { id = vm.BlogId });

            var blog = _repo.GetBlog(vm.BlogId);
            if (vm.MainCommentId == 0)
            {
                blog.MainComments = blog.MainComments ?? new List<MainComment>();

                blog.MainComments.Add(new MainComment
                {
                    Message = vm.Message,
                    Created = DateTime.Now,
                });
                _repo.UpdateBlog(blog);
            }
            else
            {
                var comment = new SubComment
                {
                    MainCommentId = vm.MainCommentId,
                    Message = vm.Message,
                    Created = DateTime.Now,
                };
                _repo.AddSubComment(comment);
            }

            await _repo.SaveChangesAsync();

            return RedirectToAction("ViewBlog", new { id = vm.BlogId });
        }
     

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
