using Api.WebMusic.Data.Context;
using Api.WebMusic.Data.Repository;
using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Data.Implemantation
{
    public class ArtistaImplementation : BaseRepository<Artista>, IArtistaRepository
    {
        private DbSet<Artista> _dataset;

        public ArtistaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Artista>();
        }

        public async Task<Artista> GetArtistaCompleto(int id)
        {
            return await _dataset.Include(c => c.Album)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Artista>> GetListCompletoArtista()
        {
            return await _dataset.Include(c => c.Album)
                            .ToListAsync();
        }
    }
}

