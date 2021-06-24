using Api.WebMusic.Data.Mapping;
using Api.WebMusic.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Data.Context
{
    public class MyContext : DbContext
    {
        public DbSet<Faixa> Faixas { get; set; }
        public DbSet<Artista>  Artistas { get; set; }
        public DbSet<Album> Albums { get; set; }

        public MyContext(DbContextOptions<MyContext> dbContextOptions): base(dbContextOptions)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new FaixaMap());
            modelBuilder.ApplyConfiguration(new AlbumMap());
            modelBuilder.ApplyConfiguration(new ArtistasMap());
            modelBuilder.ApplyConfiguration(new MidiaMap());
            modelBuilder.ApplyConfiguration(new GeneroMap());
            base.OnModelCreating(modelBuilder);
        }
    }
}
