using Api.WebMusic.Domain.Dtos.Artistas;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Interfaces.Services
{
    public interface IArtistaService
    {
        Task<ArtistaDto> Get(int id);
        Task<ArtistaDtoCompleto> GetArtistaByIdCompleto(int id);
        Task<IEnumerable<ArtistaDto>> GetAllArtistaDto();
        Task<IEnumerable<ArtistaDtoCompleto>> GetAllArtistaCompleto();
        Task<ArtistaDto> Post(ArtistaDtoCreate artistaDtoCreate);
        Task<ArtistaDto> Put(ArtistaDtoUpdate artistaDtoUpdate);
        Task<bool> Delete(int id);
    }
}
