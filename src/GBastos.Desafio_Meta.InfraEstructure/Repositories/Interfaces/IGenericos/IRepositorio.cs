﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces.Genericos
{
    public interface IRepositorio<T> where T : class
    {
        IQueryable<T> GetAll();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Seek(params object[] key);
        T First(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(Func<T, bool> predicate);
        void Commit();
        void Dispose();
    }
}
