using Api.WebMusic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Data.Mapping
{
    public class AlbumMap : IEntityTypeConfiguration<Album>
    {
        public void Configure(EntityTypeBuilder<Album> builder)
        {
            builder.ToTable("Album");

            builder.Property(c => c.Id)
                .HasColumnName("AlbumId");

            builder.Property(c => c.Titulo)
                .HasColumnName("Titulo")
                .HasColumnType("nvarchar(120)");

            builder.HasOne(c => c.Artista)
                    .WithMany(c => c.Album)
                    .HasForeignKey("ArtistaId");
        }
    }
}
