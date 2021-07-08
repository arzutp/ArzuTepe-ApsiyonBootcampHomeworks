using Blog.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogRepository : GenericRepository<BlogArticle>, IBlogRepository
    {

        //ekstra bir şey yapıldığı için context sınıfına ihityaç vardır
        public BlogRepository(BlogDbContext context) : base(context)
        {
                
        }

        public async Task AddWithCategories(BlogArticle blog)
        {
            _context.Categories.AttachRange(blog.Categories);
            _context.Tags.AttachRange(blog.Tags);
            await base.Add(blog);
        }

        public List<BlogArticle> GetAllByCategory(int categoryId)
        {
            return _context.BlogArticles.Where(x => x.Categories.Any(y => y.Id == categoryId && y.Status)).ToList();
        }
    }
}
