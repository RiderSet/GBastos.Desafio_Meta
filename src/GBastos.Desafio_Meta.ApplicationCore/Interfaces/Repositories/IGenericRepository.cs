using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        Task<TEntity> Addasync(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity>GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        void Delete(TEntity entity);
    }
}
