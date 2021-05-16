using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces.Genericos;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Linq.Expressions;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos
{
    public class Repositorio<T> : IRepositorio<T>, IDisposable where T : class
    {
        private Contexto CTX;

        public Repositorio(Contexto cTX)        
        {
            CTX = new Contexto();
        }

        public void Add(T entity)
        {
            CTX.Set<T>().Add(entity);
        }

        public T First(Expression<Func<T, bool>> predicate)
        {
            return CTX.Set<T>().Where(predicate).FirstOrDefault();
        }

        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return CTX.Set<T>().Where(predicate);
        }

        public IQueryable<T> GetAll()
        {
            return CTX.Set<T>();
        }

        public T Seek(params object[] key)
        {
            return CTX.Set<T>().Find(key);
        }

        public void Update(T entity)
        {
            CTX.Entry(entity).State = EntityState.Modified;
        }

        public void Commit()
        {
            CTX.SaveChanges();
        }

        public void Delete(Func<T, bool> predicate)
        {
            CTX.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => CTX.Set<T>().Remove(del));
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

