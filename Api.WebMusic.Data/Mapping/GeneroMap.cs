using Api.WebMusic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace Api.WebMusic.Data.Mapping
{
    public class GeneroMap : IEntityTypeConfiguration<Genero>
    {
        public void Configure(EntityTypeBuilder<Genero> builder)
        {
            builder
                .ToTable("Genero");

            builder
                .Property(c => c.Id)
                .HasColumnName("GeneroId");

            builder
                .Property(c => c.Nome)
                .HasColumnType("nvarchar(120)");
        }
    }
}
