using ETicaret.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces
{
    public interface ICategoryService
    {
        //Task Add(CategoryAddDto entity);
        //void Delete(int id);
        //void Update(BasketUpdateDto entity);
        Task<List<CategoryViewDto>> GetAll();
        Task<List<CategoryViewDto>> Get(Expression<Func<CategoryViewDto, bool>> filter);
    }
}
