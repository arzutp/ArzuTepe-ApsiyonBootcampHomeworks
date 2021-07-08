using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using SmsService.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsService.Controllers
{
    public class EMailController : BaseController
    {
        private readonly UserManager<User> _userManager;


        public EMailController(UserManager<User> userManager)
        {
            _userManager = userManager;
        }
        [HttpPost("Send")]
        public IActionResult Send(Email model)
        {
            return Ok();
        }

        [HttpPost("AddUser")]
        public IActionResult AddUser(User model)
        {

            _userManager.CreateAsync(model);
            return Ok(new { UserName = model.UserName, Success = true });
        }

        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            List<string> users = new List<string>();
            for (int i = 0; i < 10; i++)
            {
                users.Add("Kullanıcı" + i);
            }
            return Ok(users);
        }
    }
}
