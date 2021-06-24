using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Repository
{
    public interface IArtistaRepository : IRepository<Artista>
    {
        Task<IEnumerable<Artista>> GetListCompletoArtista();
        Task<Artista> GetArtistaCompleto(int id);
    }
}
