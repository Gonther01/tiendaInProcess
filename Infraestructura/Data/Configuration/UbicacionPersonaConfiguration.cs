using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configuration;
public class UbicacionPersonaConfiguration : IEntityTypeConfiguration<UbicacionPersona>
{
    public void Configure(EntityTypeBuilder<UbicacionPersona> builder)
    {
        builder.ToTable("ubicacionpersona");
        builder.HasKey(e => e.Id);
        builder.Property(e => e.Id);

        builder.Property(p => p.TipoDeVia).IsRequired().HasMaxLength(50);

        builder.Property(p => p.NumeroPri).IsRequired();

        builder.Property(p => p.NumeroSec).IsRequired();

        builder.Property(p => p.NumeroTer).IsRequired();

        builder.Property(p => p.Bis).IsRequired().HasMaxLength(10);

        builder.Property(p => p.CardinalPri).IsRequired().HasMaxLength(10);

        builder.Property(p => p.CardinalSec).IsRequired().HasMaxLength(10);

        builder.Property(p => p.LetraPri).IsRequired().HasMaxLength(2);

        builder.Property(p => p.LetraSec).IsRequired().HasMaxLength(2);

        builder.Property(p => p.LetraTer).IsRequired().HasMaxLength(2);

        builder.Property(p => p.Complemento).IsRequired().HasMaxLength(50);

        builder.HasOne(p => p.Personas).WithMany(p => p.UbicacionesPersonas).HasForeignKey(e => e.IdPersonaFk);

        builder.HasOne(p => p.Ciudades).WithMany(p => p.UbicacionesPersonas).HasForeignKey(e => e.IdCiudadFk);
    }
}