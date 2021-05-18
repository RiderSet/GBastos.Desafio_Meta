using GBastos.Desafio_Meta.ApplicationCore.Interfaces.Repositories;
using GBastos.Desafio_Meta.ApplicationCore.Models;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories
{
    public class EmissoraRepository : EFRepositorio<Emissora>, IEmissora_Rep
    {
        public EmissoraRepository(Contexto contexto) : base(contexto)
        {
        }

        public IEnumerable<Audiencia> GetAudiencias(int emissoraId)
        {
            Emissora emissora = (Emissora)CTX.Emissoras.Where(x => x.Id == emissoraId);
            return emissora.Audiencias.AsEnumerable();
        }
    }
}
