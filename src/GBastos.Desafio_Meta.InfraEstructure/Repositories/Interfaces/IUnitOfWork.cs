using GBastos.Desafio_Meta.ApplicationCore;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces.Genericos;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces
{
    public interface IUnitOfWork
    {
        IRepositorio<Audiencia> Audiencia_Rep { get; }
        IRepositorio<Emissora> Emissora_Rep { get; }

        void Commit();
    }
}
