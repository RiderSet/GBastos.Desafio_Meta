using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos
{
    public class DapperRepository<TEntity> : IGenericRepository<TEntity>, IDisposable where TEntity : class
    {
        public TEntity Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
