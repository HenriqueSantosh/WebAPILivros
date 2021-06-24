using Api.WebMusic.Domain.Dtos.Albuns;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Interfaces.Services
{
    public interface IAlbumService
    {
        Task<AlbumDto> Get(int id);
        Task<AlbumDtoCompleto> GetAlbumByIdCompleto(int id);
        Task<IEnumerable<AlbumDto>> GetAllAlbumDto();
        Task<IEnumerable<AlbumDtoCompleto>> GetAllAlbumCompleto();
        Task<AlbumDto> Post(AlbumDtoCreate albumDtoCreate);
        Task<AlbumDto> Put(AlbumDtoUpdate albumDtoUpdate);
        Task<bool> Delete(int id);
    }
}
