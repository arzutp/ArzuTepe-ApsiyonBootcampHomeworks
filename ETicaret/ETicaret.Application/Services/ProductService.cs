using AutoMapper;
using ETicaret.Application.Dto;
using ETicaret.Application.Interfaces;
using ETicaret.Domain.Models;
using ETicaret.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Services
{
    public class ProductService : IProductService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public ProductService(IUnitofWork unitofWork, IMapper mapper)
        {
            _unitofWork = unitofWork;
            _mapper = mapper;
        }

        public async Task<List<ProductViewDto>> Get(Expression<Func<ProductViewDto, bool>> filter)
        {
            var dtoFilter = _mapper.Map<Expression<Func<Product, bool>>>(filter);

            var result = await _unitofWork.Product.Get(dtoFilter);

            return _mapper.Map<List<ProductViewDto>>(result);
        }

        public async Task<List<ProductViewDto>> GetAll()
        {
            var result = await _unitofWork.Product.GetAll();
            return _mapper.Map<List<ProductViewDto>>(result);
        }

        public async Task<ProductViewDto> GetById(int id)
        {
            var result = (await _unitofWork.Product.Get(x => x.Id == id)).FirstOrDefault();
            if(result != null)
            {
                return _mapper.Map<ProductViewDto>(result);
            }
            return null;
        }

        public async Task<int> TotalCount()
        {
            return await _unitofWork.Product.TotalCount();
        }
    }
}
