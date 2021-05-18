using GBastos.Desafio_Meta.ApplicationCore.Models;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories
{
    public interface IAudiencia_Rep : IGenericRepository<Audiencia>
    {
        Emissora GetEmissoraByAudiencia(int audienciaId);
    }
}
