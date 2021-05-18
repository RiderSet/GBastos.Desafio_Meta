using GBastos.Desafio_Meta.ApplicationCore.Interfaces;
using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories;
using System.Threading.Tasks;

namespace GBastos.Desafio_Meta.InfraEstructure.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Contexto CTX;

        public UnitOfWork()
        {
        }

        public IEmissora_Rep EmissoraRep { get; private set; }
        public IAudiencia_Rep AudienciaRep { get; private set; }

        public UnitOfWork(Contexto context)
        {
            CTX = context;
            EmissoraRep = new EmissoraRepository(CTX);
            AudienciaRep = new AudienciaRepository(CTX);
        }

        public Task<int> CommitAsync()
        {
            return CTX.SaveChangesAsync();
        }

        public int Complete()
        {
            return CTX.SaveChanges();
        }
        public void Dispose()
        {
            CTX.Dispose();
        }
    }
}
