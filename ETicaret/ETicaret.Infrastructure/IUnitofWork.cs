using ETicaret.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Infrastructure
{
    public interface IUnitofWork
    {
        IBasketRepository Basket { get; }
        ICategoryRespository Category { get; }

        IProductRepository Product { get; }

        Task<int> SaveChangesAsync();
    }
}
