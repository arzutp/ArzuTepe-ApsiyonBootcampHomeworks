using AutoMapper;
using ETicaret.Application.Dto;
using ETicaret.Application.Interfaces;
using ETicaret.Domain.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure;
using ETicaret.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IUnitofWork _unitofWork = null;
        private readonly IMapper _mapper;
        public CategoryService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }
        public async Task<List<CategoryViewDto>> Get(Expression<Func<CategoryViewDto, bool>> filter)
        {
           var dtoFilter =_mapper.Map<Expression<Func<Category, bool>>>(filter);

            var result = await _unitofWork.Category.Get(dtoFilter);
           
           return  _mapper.Map<List<CategoryViewDto>>(result);
        }

        public async Task<List<CategoryViewDto>> GetAll()
        {
            var result = await _unitofWork.Category.GetAll();

            return _mapper.Map<List<CategoryViewDto>>(result); ;
        }
    }
}
