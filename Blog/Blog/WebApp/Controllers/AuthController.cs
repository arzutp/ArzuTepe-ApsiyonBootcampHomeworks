using Blog.Business.ViewModel;
using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    public class AuthController : Controller
    {
        private readonly SignInManager<User> _signInManager;
        private readonly UserManager<User> _userManager;
        public AuthController(SignInManager<User> signInManager, UserManager<User> userManager)
        {
            _signInManager = signInManager;
            _userManager = userManager;
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserViewModel model)
        {
            IdentityResult result = await _userManager.CreateAsync(new User
            {
                Email = model.Email,
                UserName = model.UserName
            }, model.Password
                 );
            if (result.Succeeded) return RedirectToAction("Login");



            return RedirectToAction("Register");
        }
        [HttpPost]
        public async Task<IActionResult> Login(string userName, string password)
        {

            var result = await _signInManager.PasswordSignInAsync(userName, password, false, false);

            if (!result.Succeeded) return RedirectToAction("Login");


            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Login");
        }
    }
}
