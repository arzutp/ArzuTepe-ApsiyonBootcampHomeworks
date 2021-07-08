using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Business.Abstract
{
    public interface IService<TEntity>
    {
        Task<bool> Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(int id);
        TEntity GetById(int id);
        List<TEntity> GetAll();
    }
}
