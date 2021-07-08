using Blog.Business.Abstract;
using Blog.Business.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Controllers
{
    [AuthorizeByRole(Roles.Admin)]
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService = null;
        private readonly ICategoryService _categoryService = null;
        private readonly ITagService _tagService = null;
        public BlogController(IBlogService blogService, ICategoryService categoryService, ITagService tagService)
        {
            _blogService = blogService;
            _categoryService = categoryService;
            _tagService = tagService;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Add()
        {
            ViewBag.Categories = _categoryService.GetAll();
            ViewBag.Tags = _tagService.GetAll();
            return View();
        }

        //kaydet butonu ile postu yakalıyoruz ve buraya geliyoruz
        [HttpPost]
        public IActionResult Add(BlogViewModel model)
        {
            _blogService.AddWithCategories(model);
            return RedirectToAction("Add");
        }


    }
}
