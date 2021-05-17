using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces.Genericos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos
{
    public class Repositorio<TEntity> : IRepositorio<TEntity>, IDisposable where TEntity : class
    {
        private Contexto CTX;

        public Repositorio()
        {
            CTX = new Contexto();
        }

        public void Add(TEntity entity)
        {
            CTX.Set<TEntity>().Add(entity);
        }

        public void AddRange(IEnumerable<TEntity> entities)
        {
            CTX.Set<TEntity>().AddRange(entities); ;
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<TEntity> Find(Expression<Func<TEntity, bool>> expression)
        {
            return CTX.Set<TEntity>().Where(expression);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return CTX.Set<TEntity>().ToList();
        }

        public TEntity GetById(int id)
        {
            return CTX.Set<TEntity>().Find(id);
        }

        public void Remove(TEntity entity)
        {
            CTX.Set<TEntity>().Remove(entity);
        }

        public void RemoveRange(IEnumerable<TEntity> entities)
        {
            CTX.Set<TEntity>().RemoveRange(entities);
        }
    }
}