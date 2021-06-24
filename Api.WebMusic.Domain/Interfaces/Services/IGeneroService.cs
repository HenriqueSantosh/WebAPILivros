using Api.WebMusic.Domain.Dtos.Generos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Interfaces.Services
{
    public interface IGeneroService
    {
        Task<GeneroDto> Get(int id);
        Task<GeneroDtoCompleto> GetGeneroByIdCompleto(int id);
        Task<IEnumerable<GeneroDto>> GetAllGeneroDto();
        Task<IEnumerable<GeneroDtoCompleto>> GetAllGeneroCompleto();
        Task<GeneroDto> Post(GeneroDtoCreate albumDtoCreate);
        Task<GeneroDto> Put(GeneroDtoUpdate albumDtoUpdate);
        Task<bool> Delete(int id);
    }
}
