using GBastos.Desafio_Meta.ApplicationCore;
using GBastos.Desafio_Meta.InfraEstructure.Data;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Genericos;
using GBastos.Desafio_Meta.InfraEstructure.Repositories.Interfaces;

namespace GBastos.Desafio_Meta.InfraEstructure.Repositories
{
    public class Audiencia_Rep : Repositorio<Audiencia>, IAudiencia_Rep
    {
        private readonly Contexto CTX;

        public Audiencia_Rep(Contexto contexto) //: base(contexto)
        {
            CTX = contexto;
        }
    }
}
