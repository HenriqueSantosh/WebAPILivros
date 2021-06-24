using Api.WebMusic.Domain.Dtos.Faixas;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Interfaces.Services
{
    public interface IFaixaService
    {
        Task<FaixaDto> Get(int id);
        Task<FaixaDtoCompleto> GetFaixaByIdCompleto(int id);
        Task<IEnumerable<FaixaDto>> GetAllFaixaDto();
        Task<IEnumerable<FaixaDtoCompleto>> GetAllFaixaCompleto();
        Task<FaixaDtoResult> Post(FaixaDtoCreate faixaDtoCreate);
        Task<FaixaDtoResult> Put(FaixaDtoUpdate faixaDtoUpdate);
        Task<bool> Delete(int id);
    }
}
