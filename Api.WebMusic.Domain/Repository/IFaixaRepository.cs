using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Repository
{
    public interface IFaixaRepository : IRepository<Faixa>
    {
        Task<IEnumerable<Faixa>> SelectCompletoFaixa();
        Task<Faixa> GetFaixaCompleta(int id);
    }
}
