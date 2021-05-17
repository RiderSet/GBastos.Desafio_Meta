using System;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmissora_Rep EmissoraRep { get; }
        IAudiencia_Rep AudienciaRep { get; }
        int Complete();
    }
}
