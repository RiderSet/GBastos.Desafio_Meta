using GBastos.Desafio_Meta.ApplicationCore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GBastos.Desafio_Meta.InfraEstructure.EntityConfig
{
    public class EmissoraMap : IEntityTypeConfiguration<Emissora>
    {
        public void Configure(EntityTypeBuilder<Emissora> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(e => e.Nome)
                .HasColumnType("varchar(100)").IsRequired();

            builder
                .HasMany(e => e.Audiencias)
                .WithOne(e => e.Emissora)
                .HasForeignKey(e => e.EmissoraId)
                .HasPrincipalKey(e => e.Id);
        }
    }
}
