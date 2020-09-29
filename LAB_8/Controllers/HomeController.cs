using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using lab8_task3.Models;

namespace lab8_task3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult test1()
        {
            int num1 = 6, num2 = 3;
            int sum = num1 + num2;
            ViewBag.num1 = num1.ToString();
            ViewBag.num2 = num2.ToString();
            ViewBag.sum = sum.ToString();
            return View();
        }

        [HttpGet]
        public IActionResult test2()
        {
            return View();
        }
        [HttpPost]
        public IActionResult test2(int n1,int n2)
        {
            ViewBag.sum = (n1 + n2).ToString();
            ViewBag.n1 = n1;
            ViewBag.n2 = n2;
            return View();
        }

        [HttpGet]
        public IActionResult user_registration()
        {
            return View();
        }
        [HttpPost]
        public IActionResult user_registration(string name,int sem)
        {
            ViewBag.tag = "Registered Successfully!!!";
            return View();
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
