using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces;
using System.Threading.Tasks;

namespace GBastos.Desafio_Meta.InfraEstructure.DAL
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Contexto CTX;

        public UnitOfWork(Contexto context)
        {
            CTX = context;
            EmissoraRep = new Emissora_Rep(CTX);
            AudienciaRep = new Audiencia_Rep(CTX);
        }

        public IEmissora_Rep EmissoraRep { get; private set; }
        public IAudiencia_Rep AudienciaRep { get; private set; }

        public Task<int> CommitAsync()
        {
            throw new System.NotImplementedException();
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
