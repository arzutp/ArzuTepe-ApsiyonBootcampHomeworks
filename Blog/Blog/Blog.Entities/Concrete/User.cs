using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entities.Concrete
{
    
    public class User : IdentityUser, IEntity
    {
        public virtual ICollection<Comment> Comments { get; set; }
        public virtual ICollection<BlogArticle> BlogArticles { get; set; }
    }

}
