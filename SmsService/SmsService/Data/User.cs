using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmsService.Data
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Company { get; set; }
    }
}
