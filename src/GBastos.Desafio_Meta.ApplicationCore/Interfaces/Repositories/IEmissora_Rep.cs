using GBastos.Desafio_Meta.ApplicationCore.Models;
using System.Collections.Generic;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories
{
    public interface IEmissora_Rep : IGenericRepository<Emissora>
    {
        IEnumerable<Audiencia> GetAudiencias(int emissoraId);
    }
}
