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
    public class GeneroImplementation : BaseRepository<Genero>, IGeneroRepository
    {
        private DbSet<Genero> _dataset;

        public GeneroImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Genero>();
        }
        public async Task<Genero> GetGeneroCompleto(int id)
        {
            return await _dataset.Include(c => c.Faixas)
                   .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Genero>> SelectCompletoGenero()
        {
            return await _dataset.Include(c => c.Faixas)
                               .ToListAsync();
        }
    }
}
