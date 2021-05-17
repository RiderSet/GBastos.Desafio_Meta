using System.Collections.Generic;

namespace GBastos.Desafio_Meta.ApplicationCore
{
    public class Emissora
    {
        public Emissora()
        { }

        public Emissora(int emissoraId)
        {
            Id = emissoraId;
            Audiencias = new List<Audiencia>();
        }

        public int Id { get; set; }
        public string Nome { get; set; }

        public List<Audiencia> Audiencias { get; set; }

        public bool Validate()
        {
            bool isValid = true;
            foreach (char e in Nome)
            {
                if (!char.IsControl(e) && !char.IsDigit(e) && (e != '.'))
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
