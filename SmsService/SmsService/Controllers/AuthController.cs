using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {

        private IConfiguration _configuration;
        public AuthController(IConfiguration configuration)
        {
            _configuration = configuration;
        }



        [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
        [HttpGet("Index")]
        public IActionResult Index()
        {
            return Ok("yetkili giriş");
        }


        [AllowAnonymous]
        [HttpGet("Login")]
        public IActionResult Login(string userName, string password)
        {
            if(userName == "a" && password == "a")
            {
                JwtService jwtService = new JwtService(_configuration);
                string token = jwtService.CreateAccessToken(new Data.User { Name = "a", Email = "a@a.com" });
               return  Ok(new { token=token });
            }

            return BadRequest();
        }
    }
}
