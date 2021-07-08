using ETicaret.Application.Dto;
using ETicaret.Application.Interfaces;
using ETicaret.Infrastructure;
using ETicaret.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService, ICategoryService categoryService)
        {
            _productService = productService;
            _categoryService = categoryService;
        }
        public async Task<IActionResult> Index(int id = 0, int page = 0)
        {
            int perPage = 2;

            var model = new ProductsViewModel();

            var totalCount = await _productService.TotalCount();

            if (id > 0)
            {
                model.Categories = await _categoryService.Get(x => x.Id == id);
                model.Products =  (await _productService.Get(x => x.Category.Id == id)).Skip(page * perPage).Take(perPage).ToList();
            }
            else
            {
                model.Categories = await _categoryService.GetAll();
                model.Products = (await _productService.GetAll()).Skip(page * perPage).Take(perPage).ToList();
            }

            

            model.Paging = new PagingViewModel();
            model.Paging.CurrentPage = page;
            model.Paging.PerPage = perPage;
            model.Paging.TotalPageCount =(int)Math.Ceiling(((double)totalCount / (double)model.Paging.PerPage));




            return View(model);
        }


        //public async Task<IActionResult> CategoryDetail(int id)
        //{
        //    var model = await _productService.Get(x => x.Category.Id == id);
        //    return View(model);
        //}
        public async Task<IActionResult> Detail(int id)
        {
            var model = await _productService.GetById(id);
            return View(model);
        }
    }
}
