using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories;
using GBastos.Desafio_Meta.ApplicationCore.Models;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories
{
    public class AudienciaRepository : EFRepositorio<Audiencia>, IAudiencia_Rep
    {
        public AudienciaRepository(Contexto contexto) : base(contexto)
        {
        }

        public Emissora GetEmissoraByAudiencia(int audienciaId)
        {
            return (Emissora)Get(x => x.Id == audienciaId);
        }
    }
}
