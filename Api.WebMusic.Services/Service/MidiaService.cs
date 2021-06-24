using Api.WebMusic.Domain.Dtos.Midias;
using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Interfaces.Services;
using Api.WebMusic.Domain.Models;
using Api.WebMusic.Domain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.WebMusic.Services.Service
{
    public class MidiaService : IMidiaServices
    {
        private readonly IMidiaRepository _repository;
        private IMapper _mapper;

        public MidiaService(IMidiaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await  _repository.DeleteAsync(id);
        }

        public async Task<MidiaDto> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<MidiaDto>(entity);

        }

        public async Task<IEnumerable<MidiaDtoCompleto>> GetAllMidiaCompleto()
        {
            var listMidia = await _repository.SelectCompletoMidia();
            return _mapper.Map<IEnumerable<MidiaDtoCompleto>>(listMidia);
        }

        public async Task<IEnumerable<MidiaDto>> GetAllMidiaDto()
        {
            var listMidia = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<MidiaDto>>(listMidia);
        }

        public async Task<MidiaDtoCompleto> GetMidiaByIdCompleto(int id)
        {
            var entityMidia = await _repository.GetMidiaCompleta(id);
            return _mapper.Map<MidiaDtoCompleto>(entityMidia);
        }

        public async Task<MidiaDto> Post(MidiaDtoCreate midiaDtoCreate)
        {
            var entityModel = _mapper.Map<MidiaModel>(midiaDtoCreate);
            var entity = _mapper.Map<Midia>(entityModel);
            var resultEntity = await _repository.InsertAsync(entity);
            var MidiaDtoResult = _mapper.Map<MidiaDto>(resultEntity);
            return MidiaDtoResult;
        }

        public async Task<MidiaDto> Put(MidiaDtoUpdate midiaDtoUpdate)
        {
            var entityModel = _mapper.Map<MidiaModel>(midiaDtoUpdate);
            var entity = _mapper.Map<Midia>(entityModel);
            var resultEntity = await _repository.UpdateAsync(entity);
            var MidiaDtoResult = _mapper.Map<MidiaDto>(resultEntity);
            return MidiaDtoResult;

        }
    }
}
