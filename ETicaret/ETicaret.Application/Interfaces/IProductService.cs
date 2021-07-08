using ETicaret.Application.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Application.Interfaces
{
    public interface IProductService
    {
        Task<List<ProductViewDto>> GetAll();
        Task<ProductViewDto> GetById(int id);
        Task<List<ProductViewDto>> Get(Expression<Func<ProductViewDto, bool>> filter);
        Task<int> TotalCount();
    }
}
