using Api.WebMusic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Api.WebMusic.Data.Mapping
{
    public class ArtistasMap : IEntityTypeConfiguration<Artista>
    {

        public void Configure(EntityTypeBuilder<Artista> builder)
        {
            builder.ToTable("Artista");

            builder
                .Property(c => c.Id)
                .HasColumnName("ArtistaId");

            builder.Property(c => c.Nome)
                    .HasColumnName("Nome");
        }
    }
}
