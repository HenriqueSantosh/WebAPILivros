using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Repository
{
    public interface IGeneroRepository : IRepository<Genero>
    {
        Task<IEnumerable<Genero>> SelectCompletoGenero();
        Task<Genero> GetGeneroCompleto(int id);
    }
}
