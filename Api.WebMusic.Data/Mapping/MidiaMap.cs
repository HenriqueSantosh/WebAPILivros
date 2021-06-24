using Api.WebMusic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.WebMusic.Data.Mapping
{
    public class MidiaMap : IEntityTypeConfiguration<Midia>
    {
        public void Configure(EntityTypeBuilder<Midia> builder)
        {
            builder
                    .ToTable("TipoMidia");

            builder
                .Property(a => a.Id)
                .HasColumnName("TipoMidiaId");

            builder
                .Property(a => a.Nome)
                    .HasColumnName("Nome")
                    .HasColumnType("nvarchar(120)");
        }
    }
}
