using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories;
using System;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IEmissora_Rep EmissoraRep { get; }
        IAudiencia_Rep AudienciaRep { get; }
        int Complete();
    }
}
