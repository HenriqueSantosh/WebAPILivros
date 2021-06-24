using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Interfaces
{
    public interface IRepository<T> where T : class 
    {
        Task<T> InsertAsync(T obj);
        Task<T> UpdateAsync(T obj);
        Task<bool> DeleteAsync(int obj);
        Task<T> SelectAsync(int id);
        Task<IEnumerable<T>> SelectAsync();
        Task<bool> ExistAsync(int id);
    }
}
