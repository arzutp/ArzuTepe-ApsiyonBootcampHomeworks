using AutoMapper;
using Blog.Business.Abstract;
using Blog.Business.ViewModel;
using Blog.Entities.Concrete;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class BlogService : IBlogService
    {
        //Burada repositorye erişmek gerekli injection kullanılmalı
        private readonly IBlogRepository _blogDal;
        private readonly IMapper _mapper;
        public BlogService(IBlogRepository blogDal, IMapper mapper)
        {
            _blogDal = blogDal;
            _mapper = mapper;
        }
            

        public async Task<bool> Add(BlogViewModel blog)
        {

            //AutoMapper ile kullanılımı hepsi IMApper diye kullanılır
            blog.Categories = blog.SelectedCategories.Select(x => new CategoryViewModel { Id = x }).ToList();
            blog.Tags = blog.SelectedTags.Select(x => new TagViewModel { Id = x }).ToList();

            int id = await _blogDal.Add(new BlogArticle
            {
                Article = blog.Article,
                CreatedAt = DateTime.Now,
                Title = blog.Title,
                UserId = blog.UserId,
                Categories = _mapper.Map<List<Category>>(blog.Categories),
                Tags = _mapper.Map<List<Tag>>(blog.Tags)
            });
            return id > 0;
        }

        public async Task AddWithCategories(BlogViewModel blog)
        {
            blog.Categories = blog.SelectedCategories.Select(x => new CategoryViewModel { Id = x }).ToList();
            blog.Tags = blog.SelectedTags.Select(x => new TagViewModel { Id = x }).ToList();
            await _blogDal.AddWithCategories(_mapper.Map<BlogArticle>(blog));
            
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<BlogViewModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public List<BlogViewModel> GetAllByCategory(int categoryId)
        {
            List<BlogViewModel> blogs = new List<BlogViewModel>();
            var currentBlogs = _blogDal.GetAllByCategory(categoryId);

            foreach (var item in currentBlogs)
            {
                blogs.Add(new BlogViewModel
                {
                    Article = item.Article,
                    Title = item.Title,
                    Categories = _mapper.Map<List<CategoryViewModel>>(item.Categories)
                });
            }
            return blogs;
        }
        
        public BlogViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(BlogViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
