using ETicaret.Domain.Interfaces;
using ETicaret.Infrastructure.Context;
using ETicaret.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.Infrastructure
{
    public class UnitofWork : IUnitofWork
    {
        public IBasketRepository Basket { get; }

        public ICategoryRespository Category { get; }

        public IProductRepository Product { get; }

        private readonly ETicaretDbContext _context;

        public UnitofWork(ETicaretDbContext context, IBasketRepository basketRepository, ICategoryRespository categoryRespository, IProductRepository productRepository)
        {
            _context = context;
            Basket = basketRepository;
            Category = categoryRespository;
            Product = productRepository;
        }

        public async Task<int> SaveChangesAsync()
        {
 
            return await _context.SaveChangesAsync();
        }
    }
}
