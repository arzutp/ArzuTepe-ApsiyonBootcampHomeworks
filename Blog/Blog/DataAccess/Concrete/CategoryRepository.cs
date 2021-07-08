using Blog.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategoryRepository :  GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(BlogDbContext context) : base(context)
        {
                
        }
    }
}
