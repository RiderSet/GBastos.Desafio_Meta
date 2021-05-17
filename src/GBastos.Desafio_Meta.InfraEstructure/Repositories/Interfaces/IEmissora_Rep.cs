using GBastos.Desafio_Meta.ApplicationCore;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces.Genericos;
using System.Collections.Generic;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces
{
    public interface IEmissora_Rep : IRepositorio<Emissora>
    {
        IEnumerable<Audiencia> GetAudiencias(int count);
    }
}
