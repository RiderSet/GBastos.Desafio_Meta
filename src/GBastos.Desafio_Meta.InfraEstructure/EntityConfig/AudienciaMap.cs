using GBastos.Desafio_Meta.ApplicationCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GBastos.Desafio_Meta.InfraEstructure.EntityConfig
{
    public class AudienciaMap : IEntityTypeConfiguration<Audiencia>
    {
        public void Configure(EntityTypeBuilder<Audiencia> builder)
        {
            builder.HasKey(c => c.Id);
        }
    }
}
