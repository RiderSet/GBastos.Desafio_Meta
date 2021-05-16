﻿using System;
using System.Collections.Generic;

namespace GBastos.Desafio_Meta.ApplicationCore.Interfaces
{
    public interface IEmissora: IDisposable
    {
        IEnumerable<Audiencia> GetAudiencias();
        Audiencia GetAudienciaByID(int studentId);
        void InsertAudiencia(Audiencia student);
        void DeleteAudiencia(int AudienciaID);
        void UpdateAudiencia(Audiencia audiencia);
        void Save();
    }
}
