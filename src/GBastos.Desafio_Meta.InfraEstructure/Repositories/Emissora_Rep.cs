using GBastos.Desafio_Meta.ApplicationCore;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories
{
    public class Emissora_Rep : Repositorio<Emissora>, IEmissora_Rep
    {
        private readonly Contexto CTX;

        public Emissora_Rep(Contexto contexto) //: base(contexto)
        {
            CTX = contexto;
        }

        public IEnumerable<Audiencia> GetAudiencias(int EmissoraId)
        {
            IEnumerable<Audiencia> lista = new List<Audiencia>();
            lista = (IEnumerable<Audiencia>)CTX.Emissoras.Where(d => d.Id == EmissoraId).ToList();
            return lista;
        }
    }
}
