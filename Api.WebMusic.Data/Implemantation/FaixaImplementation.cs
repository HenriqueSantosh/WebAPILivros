using Api.WebMusic.Data.Context;
using Api.WebMusic.Data.Repository;
using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.WebMusic.Data.Implemantation
{
    public class FaixaImplementation : BaseRepository<Faixa>, IFaixaRepository
    {
            private DbSet<Faixa> _dataset;

        public FaixaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Faixa>();
        }

        public async Task<Faixa> GetFaixaCompleta(int id)
        {
            return await _dataset
                .Include(m => m.Midia)
                .Include(g => g.Genero)
                .Include(c => c.Album)
                .ThenInclude(a => a.Artista)
                .SingleOrDefaultAsync(f => f.Id == id);
        }

        public async Task<IEnumerable<Faixa>> SelectCompletoFaixa()
        {
            var ListFaixas = await _dataset
                .Include(m => m.Midia)
                .Include(g => g.Genero)
                .Include(c => c.Album)
                .ThenInclude(a => a.Artista)
                .ToListAsync();
                                
            return ListFaixas;
        }
    }
}
