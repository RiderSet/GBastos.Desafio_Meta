using GBastos.Desafio_Meta.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces.Services
{
    public interface IAudiencia_Srv
    {
        Audiencia Add(Audiencia entity);
        Task<Audiencia> Addasync(Audiencia entity);
        void Update(Audiencia entity);
        IEnumerable<Audiencia> GetAll();
        Audiencia GetById(int id);
        IEnumerable<Audiencia> Get(Expression<Func<Audiencia, bool>> predicate);
        void Delete(Audiencia entity);
    }
}
