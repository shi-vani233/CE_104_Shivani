using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogSpot.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace BlogSpot.Controllers
{
    public class AuthController : Controller
    {
        private SignInManager<IdentityUser> _signInManager;
        private UserManager<IdentityUser> _userManager;

        public AuthController(
            SignInManager<IdentityUser> signInManager,
            UserManager<IdentityUser> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View(new LoginViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel v)
        {
            if(v.UserName==null || v.Password==null)
            {
                ViewBag.Message = "Please,Fill All the fields!";
                return View(v);
            }

            var result= await _signInManager.PasswordSignInAsync(v.UserName, v.Password,false,false);
            if (!result.Succeeded)
            {
                ViewBag.Message = "Please,Enter Correct Credentials!";
                return View(v);

            }
            /* var user = HttpContext.User;
             var isAdmin = User.IsInRole("Admin");*/
            var user = await _userManager.FindByNameAsync(v.UserName);
            var isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
            if (isAdmin)
            {
                return RedirectToAction("Index", "Panel");
            }
            return RedirectToAction("Index", "Home");

        }


        [HttpGet]
        public IActionResult Register()
        {
            return View(new RegisterViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel v)
        {
            if(!ModelState.IsValid)
            {
                return View(v);
            }

            var user = new IdentityUser
            {
                UserName = v.Email,
                Email = v.Email
            };
            var result = await _userManager.CreateAsync(user,v.Password);

            if(!result.Succeeded)
            {
                return View(v);
               
            }
            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }


        [HttpGet]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

    }
}
