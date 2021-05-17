using System;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces.IDAL
{
    public interface IUnitOfWork : IDisposable
    {
        IEmissora_Rep EmissoraRep { get; }
        IAudiencia_Rep AudienciaRep { get; }
        int Complete();
    }
}
