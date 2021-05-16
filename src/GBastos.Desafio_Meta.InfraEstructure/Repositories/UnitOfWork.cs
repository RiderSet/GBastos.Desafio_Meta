using GBastos.Desafio_Meta.ApplicationCore;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces.Genericos;
using System;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private Contexto CTX = null;

        private Repositorio<Audiencia> audiencia_Rep = null;
        private Repositorio<Emissora> emissora_Rep = null;

        public UnitOfWork()
        {
            CTX = new Contexto();
        }

        public IRepositorio<Emissora> Emissora_Rep
        {
            get
            {
                if (emissora_Rep == null)
                {
                    emissora_Rep = new Repositorio<Emissora>(CTX);
                }
                return emissora_Rep;
            }
        }

        public IRepositorio<Audiencia> Audiencia_Rep
        {
            get
            {
                if (audiencia_Rep == null)
                {
                    audiencia_Rep = new Repositorio<Audiencia>(CTX);
                }
                return audiencia_Rep;
            }
        }

        public void Commit()
        {
            CTX.SaveChanges();
        }

        void IDisposable.Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
