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
    public class AlbumImplementation : BaseRepository<Album>, IAlbumRepository
    {
        private DbSet<Album> _dataset;

        public AlbumImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Album>();
        }

        public async Task<Album> GetAlbumCompleto(int id)
        {
            return await _dataset.Include(c => c.Artista)
                                        .Include(c => c.Faixas)
                .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Album>> GetAllAlbumCompletos()
        {
            return await _dataset.Include(c => c.Artista)
                                        .Include(c => c.Faixas)
                                        .ToListAsync();
        }
    }
}
