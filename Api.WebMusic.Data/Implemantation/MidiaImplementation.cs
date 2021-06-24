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
    public class MidiaImplementation : BaseRepository<Midia>, IMidiaRepository
    {
        private DbSet<Midia> _dataset;

        public MidiaImplementation(MyContext context) : base(context)
        {
            _dataset = context.Set<Midia>();
        }

        public async Task<Midia> GetMidiaCompleta(int id)
        {
            return await _dataset.Include(c => c.Faixas)
                   .SingleOrDefaultAsync(c => c.Id == id);
        }

        public async Task<IEnumerable<Midia>> SelectCompletoMidia()
        {
            return await _dataset.Include(c => c.Faixas)
                               .ToListAsync();
        }
    }
}
