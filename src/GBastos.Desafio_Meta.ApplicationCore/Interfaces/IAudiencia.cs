using GBastos.Desafio_Meta.ApplicationCore.Models;
using System;
using System.Collections.Generic;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces
{
    public interface IAudiencia: IDisposable
    {
        IEnumerable<Audiencia> GetAudiencias();
        Audiencia GetAudienciaByID(int studentId);
        void InsertAudiencia(Audiencia student);
        void DeleteAudiencia(int AudienciaID);
        void UpdateAudiencia(Audiencia audiencia);
        void Save();
    }
}
