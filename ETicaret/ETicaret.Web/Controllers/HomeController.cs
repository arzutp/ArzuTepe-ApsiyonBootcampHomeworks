using ETicaret.Application.Interfaces;
using ETicaret.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Web.Controllers
{
    public class HomeController : Controller
    {
      
        private readonly ICategoryService _categoryService = null;

        public HomeController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Products()
        {
            var model = new ProductsViewModel();
            model.Categories = await _categoryService.GetAll();
            return View(model);
          
        }

        public IActionResult Detail(int categoryId)
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
