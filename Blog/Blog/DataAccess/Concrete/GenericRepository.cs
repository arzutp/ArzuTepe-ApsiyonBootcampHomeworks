using Blog.Core.DataAccess;
using Blog.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class GenericRepository<TEntity> : IEntityRepository<TEntity> where TEntity : class
       

    {
        protected readonly BlogDbContext _context = null;
        private DbSet<TEntity> _entities;

        public GenericRepository(BlogDbContext context) 
        {
            _context = context;
            _entities = context.Set<TEntity>();
        }

        public async Task<int> Add(TEntity entity)
        {
            _entities.Add(entity);
            return await _context.SaveChangesAsync();
        }

        public void Delete(TEntity entity)
        {
            _entities.Remove(entity);
        }

        public List<TEntity> GetAll()
        {
            return _entities.ToList();
        }

        public async Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public int Update(TEntity entity)
        {
            return _context.SaveChanges();
        }
    }
}
