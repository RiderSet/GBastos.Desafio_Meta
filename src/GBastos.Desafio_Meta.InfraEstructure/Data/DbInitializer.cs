using GBastos.Desafio_Meta.ApplicationCore.Models;
using System;
using System.Linq;

namespace GBastos.Desafio_Meta.InfraEstructure.Data
{
    public class DbInitializer
    {
        public static void Initialize(Contexto CTX)
        {
            if (CTX.Emissoras.Any())
            {
                return;
            }
            var emissoras = new Emissora[]
                {
                    new Emissora
                    {
                        Nome = "TV Globo"
                    },
                    new Emissora
                    {
                        Nome = "TV Bandeirantes"
                    }
                };

            CTX.AddRange(emissoras);

            var audiencias = new Audiencia[]
            {
                    new Audiencia
                    {
                        PtsAudiencia = 5000,
                        DtHrAudiencia = Convert.ToDateTime("01/15/2021 13:00:00"),
                        EmissoraId = emissoras[0].Id,
                        Emissora = emissoras[0]
                    },
                    new Audiencia
                    {
                        PtsAudiencia = 4700,
                        DtHrAudiencia = Convert.ToDateTime("02/12/2021 13:18:02"),
                        EmissoraId = emissoras[1].Id,
                        Emissora = emissoras[1]
                    }
           };

            CTX.AddRange(audiencias);
        }
    }
}
