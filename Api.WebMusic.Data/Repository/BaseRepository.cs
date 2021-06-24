using Api.WebMusic.Data.Context;
using Api.WebMusic.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Data.Repository
{
    public class BaseRepository<T> : IRepository<T> where T : class
    {
        private readonly MyContext _context;
        private DbSet<T> _dataSet;

        public BaseRepository(MyContext context)
        {
            _context = context;
            _dataSet = _context.Set<T>();
        }

        public async Task<bool> DeleteAsync(int obj)
        {
            var entity = await _dataSet.FindAsync(obj);

            if (entity == null) return false;

            _dataSet.Remove(entity);
            await _context.SaveChangesAsync();
            return  true;
        }

        public async Task<bool> ExistAsync(int id)
        {
            var entity = await  _dataSet.FindAsync(id);
            return entity != null;
        }

        public async Task<T> InsertAsync(T obj)
        {
            await _dataSet.AddAsync(obj);
            await _context.SaveChangesAsync();
            return obj;
        }
         
        public async Task<T> SelectAsync(int id)
        {
            return await _dataSet.FindAsync(id);
        }

        public async Task<IEnumerable<T>> SelectAsync()
        {
            return await _dataSet.ToListAsync();
        }

        public async Task<T> UpdateAsync(T obj)
        {
             _dataSet.Update(obj);
            await _context.SaveChangesAsync();
            return obj;
        }
    }
}
