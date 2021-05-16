using System;

namespace GBastos.Desafio_Meta.ApplicationCore
{
    public class Audiencia
    {
        public Audiencia()
        {

        }

        public int Id { get; set; }
        public long PtsAudiencia { get; set; }
        public DateTime DtHrAudiencia { get; set; }

        public int EmissoraId { get; set; }
        public Emissora Emissora { get; set; }
    }
}
