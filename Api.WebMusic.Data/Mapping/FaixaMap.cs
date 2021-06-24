using Api.WebMusic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Data.Mapping
{
    public class FaixaMap : IEntityTypeConfiguration<Faixa>
    {
        public void Configure(EntityTypeBuilder<Faixa> builder)
        {
            builder.ToTable("Faixa");

            builder.Property(c => c.Id)
                .HasColumnName("FaixaId");

            builder.Property(c => c.Nome)
                .HasColumnName("Nome")
                .HasColumnType("nvarchar(200)");

            builder.Property(c => c.Compositor)
                .HasColumnName("Compositor")
                .HasColumnType("nvarchar(220)");

            builder.Property(c => c.Millisegundos)
                .HasColumnName("Milissegundos")
                .HasColumnType("int");

            builder.Property(c => c.Bytes)
                .HasColumnType<Int32>("int");

            builder.Property(c => c.PreçoUnitario)
                .HasColumnName("PrecoUnitario")
            .HasColumnType("numeric(10,2)");

            builder.HasOne(c => c.Album)
                .WithMany(c => c.Faixas)
                .HasForeignKey("AlbumId");

            builder.HasOne(c => c.Genero)
                    .WithMany(c => c.Faixas)
                    .HasForeignKey("GeneroId");

            builder.HasOne(c => c.Midia)
                .WithMany(c => c.Faixas)
                .HasForeignKey("TipoMidiaId");
        }
    }
}
