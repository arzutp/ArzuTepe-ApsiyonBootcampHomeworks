using Blog.Entities.Concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Concrete
{
    public class BlogDbContext : IdentityDbContext<User>
    {


        public BlogDbContext(DbContextOptions<BlogDbContext> context): base(context)
        {
                
        }
        public DbSet<BlogArticle> BlogArticles { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<User> UsersTable { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
