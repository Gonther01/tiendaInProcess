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
    }
}