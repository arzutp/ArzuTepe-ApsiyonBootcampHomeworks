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
    public class BasketService : IBasketService
    {
        private readonly IUnitofWork _unitofWork;
        private readonly IMapper _mapper;
        public BasketService(IUnitofWork unitofWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitofWork = unitofWork;
        }
        public async Task Add(BasketAddDto entity)
        {
            await _unitofWork.Basket.Add(_mapper.Map<Basket>(entity));
            await _unitofWork.Basket.Add(_mapper.Map<Basket>(entity));
            await _unitofWork.Basket.Add(_mapper.Map<Basket>(entity));
            await _unitofWork.Basket.Add(_mapper.Map<Basket>(entity));
            await _unitofWork.Basket.Add(_mapper.Map<Basket>(entity));
            await _unitofWork.Basket.Add(_mapper.Map<Basket>(entity));
            await _unitofWork.Basket.Add(_mapper.Map<Basket>(entity));

            await _unitofWork.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<BasketViewDto>> Get(Expression<Func<BasketViewDto, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public Task<List<BasketViewDto>> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Update(BasketUpdateDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
