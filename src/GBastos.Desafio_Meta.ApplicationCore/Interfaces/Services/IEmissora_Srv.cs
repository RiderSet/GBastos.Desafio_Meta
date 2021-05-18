using GBastos.Desafio_Meta.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces.Services
{
    public interface IEmissora_Srv
    {
        Emissora Add(Emissora entity);
        Task<Emissora> Addasync(Emissora entity);
        void Update(Emissora entity);
        IEnumerable<Emissora> GetAll();
        Emissora GetById(int id);
        IEnumerable<Emissora> Get(Expression<Func<Emissora, bool>> predicate);
        void Delete(Emissora entity);
    }
}
