using GBastos.Desafio_Meta.ApplicationCore.Interfaces;
using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Services;
using GBastos.Desafio_Meta.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBastos.Desafio_Meta.ApplicationCore.Services
{
    public class EmissoraService : IEmissora_Srv
    {
        private IUnitOfWork uwk;

        public EmissoraService(IUnitOfWork unitOfWork)
        {
            uwk = unitOfWork; 
        }

        public Emissora Add(Emissora entity)
        {
            return uwk.EmissoraRep.Add(entity);
        }

        public async Task<Emissora> Addasync(Emissora entity)
        {
            return await uwk.EmissoraRep.Addasync(entity);
        }

        public void Update(Emissora entity)
        {
            uwk.EmissoraRep.Update(entity);
        }

        public IEnumerable<Emissora> Get(Expression<Func<Emissora, bool>> predicate)
        {
            return uwk.EmissoraRep.Get(predicate);
        }

        public Emissora GetById(int id)
        {
            return uwk.EmissoraRep.GetById(id);
        }

        public IEnumerable<Emissora> GetAll()
        {
            return uwk.EmissoraRep.GetAll();
        }

        public void Delete(Emissora entity)
        {
            uwk.EmissoraRep.Delete(entity);
        }
    }
}
