using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            string token;

            using (HttpClient client = new HttpClient())
            {
                using (var response = await client.GetAsync("http://localhost:60178/api/auth/login?userName=n&password=a"))
                {
                    token= await response.Content.ReadAsStringAsync();

                    token = "dsdsdsds";

                }

                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                using (var response = await client.GetAsync("http://localhost:60178/api/home/index"))
                {

                    string result = await response.Content.ReadAsStringAsync();


                }

            }
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
