using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class HomeController : BaseController
    {
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return Ok("yetkili giriş");
        }
    }
}
