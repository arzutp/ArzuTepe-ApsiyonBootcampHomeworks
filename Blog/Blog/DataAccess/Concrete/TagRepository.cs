using Blog.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(BlogDbContext context) : base(context)
        {

        }
    }
}
