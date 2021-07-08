using Book_Homework1.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Homework1.Controllers
{
    public class HomeController : Controller
    {




        public IActionResult Index()
        {
            return View();
        }

       
       
    }
}
