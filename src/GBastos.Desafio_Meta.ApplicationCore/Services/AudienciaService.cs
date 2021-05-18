using GBastos.Desafio_Meta.ApplicationCore.Interfaces;
using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Services;
using GBastos.Desafio_Meta.ApplicationCore.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace GBastos.Desafio_Meta.ApplicationCore.Services
{
    public class AudienciaService : IAudiencia_Srv
    {
        private IUnitOfWork uwk;

        public AudienciaService(IUnitOfWork unitOfWork)
        {
            uwk = unitOfWork;
        }

        public Audiencia Add(Audiencia entity)
        {
            return uwk.AudienciaRep.Add(entity);
        }

        public async Task<Audiencia> Addasync(Audiencia entity)
        {
            return await uwk.AudienciaRep.Addasync(entity);
        }

        public void Delete(Audiencia entity)
        {
            uwk.AudienciaRep.Delete(entity);
        }

        public IEnumerable<Audiencia> Get(Expression<Func<Audiencia, bool>> predicate)
        {
            return uwk.AudienciaRep.Get(predicate);
        }

        public IEnumerable<Audiencia> GetAll()
        {
            return uwk.AudienciaRep.GetAll();
        }

        public Audiencia GetById(int id)
        {
            return uwk.AudienciaRep.GetById(id);
        }

        public void Update(Audiencia entity)
        {
            uwk.AudienciaRep.Update(entity);
        }
    }
}
