using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Core.DataAccess
{
    public interface IEntityRepository<TEntity> where TEntity : class
    {

        Task<int> Add(TEntity entity);
        int Update(TEntity entity);
        void Delete(TEntity entity);
        List<TEntity> GetAll();
        Task<List<TEntity>> Get(Expression<Func<TEntity, bool>> filter);

    }
}
