using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp
{
    public class AuthorizeByRoleAttribute : AuthorizeAttribute
    {
        public AuthorizeByRoleAttribute(params string[] roles)
        {

            Roles = string.Join(",", roles);
        }
    
    }
}
