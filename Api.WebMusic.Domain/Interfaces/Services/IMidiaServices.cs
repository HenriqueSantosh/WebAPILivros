using Api.WebMusic.Domain.Dtos.Midias;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.WebMusic.Domain.Interfaces.Services
{
    public interface IMidiaServices
    {
        Task<MidiaDto> Get(int id);
        Task<MidiaDtoCompleto> GetMidiaByIdCompleto(int id);
        Task<IEnumerable<MidiaDto>> GetAllMidiaDto();
        Task<IEnumerable<MidiaDtoCompleto>> GetAllMidiaCompleto();
        Task<MidiaDto> Post(MidiaDtoCreate midiaDtoCreate);
        Task<MidiaDto> Put(MidiaDtoUpdate midiaDtoUpdate);
        Task<bool> Delete(int id);
    }
}
