using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos
{
    public class EFRepositorio<TEntity> : IGenericRepository<TEntity>, IDisposable where TEntity : class
    {
        protected readonly Contexto CTX;

        public EFRepositorio(Contexto contexto)
        {
            CTX = contexto;
        }

        public virtual TEntity Add(TEntity entity)
        {
            CTX.Set<TEntity>().Add(entity);
            CTX.SaveChanges();
            return entity;
        }

        public virtual void Update(TEntity entity)
        {
            CTX.Entry(entity).State = (Microsoft.EntityFrameworkCore.EntityState)EntityState.Modified;
            CTX.SaveChanges();
        }

        public IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate)
        {
            return CTX.Set<TEntity>().Where(predicate).AsEnumerable();
        }

        public virtual TEntity GetById(int id)
        {
            return CTX.Set<TEntity>().Find(id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return CTX.Set<TEntity>().AsEnumerable();
        }

        public void Delete(TEntity entity)
        {
            CTX.Set<TEntity>().Remove(entity);
            CTX.SaveChanges();
        }

        public void Dispose()
        {
            if (CTX != null)
            {
                CTX.Dispose();
            }

            GC.SuppressFinalize(this);
        }
    }
}