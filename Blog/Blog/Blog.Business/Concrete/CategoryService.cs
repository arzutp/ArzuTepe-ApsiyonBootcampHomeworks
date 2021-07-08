using AutoMapper;
using Blog.Business.Abstract;
using Blog.Business.ViewModel;
using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Concrete
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository = null;
        private IMapper _mapper;
        
        public CategoryService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        public Task<bool> Add(CategoryViewModel entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<CategoryViewModel> GetAll()
        {
            //neyi döndüreceğiz ve nerden döndüreceğiz
            return _mapper.Map<List<CategoryViewModel>>(_categoryRepository.GetAll());
        }

        public CategoryViewModel GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Update(CategoryViewModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
