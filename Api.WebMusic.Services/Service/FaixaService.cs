using Api.WebMusic.Domain.Dtos.Faixas;
using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Interfaces.Services;
using Api.WebMusic.Domain.Models;
using Api.WebMusic.Domain.Repository;
using AutoMapper;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.WebMusic.Services.Service
{
    public class FaixaService : IFaixaService
    {
        private readonly IFaixaRepository _repository;

        private IMapper _mapper;


        public FaixaService(IFaixaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async  Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<FaixaDto> Get(int id)
        {
            var faixaDto =  await _repository.SelectAsync(id);
            return _mapper.Map<FaixaDto>(faixaDto);
        }

        public async Task<IEnumerable<FaixaDtoCompleto>> GetAllFaixaCompleto()
        {
           var listFaixaDto =  await _repository.SelectCompletoFaixa();
            return _mapper.Map<IEnumerable<FaixaDtoCompleto>>(listFaixaDto);
        }

        public async Task<IEnumerable<FaixaDto>> GetAllFaixaDto()
        {
            var listFaixaDto = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<FaixaDto>>(listFaixaDto);
        }
        public async Task<FaixaDtoCompleto> GetFaixaByIdCompleto(int id)
        {
            var entityFaixa = await _repository.GetFaixaCompleta(id);
            return _mapper.Map<FaixaDtoCompleto>(entityFaixa);
        }

        public async Task<FaixaDtoResult> Post(FaixaDtoCreate faixaDtoCreate)
        {
            var entityModel = _mapper.Map<FaixaModel>(faixaDtoCreate);
            var entity = _mapper.Map<Faixa>(entityModel);
            var resultEntity = await _repository.InsertAsync(entity);
            var faixaDtoResult = _mapper.Map<FaixaDtoResult>(resultEntity);
            return faixaDtoResult;
        }

        public async Task<FaixaDtoResult> Put(FaixaDtoUpdate faixaDtoUpdate)
        {
            var entityModel = _mapper.Map<FaixaModel>(faixaDtoUpdate);
            var entity = _mapper.Map<Faixa>(entityModel);
            var resultEntity = await _repository.UpdateAsync(entity);
            var faixaDtoResult = _mapper.Map<FaixaDtoResult>(resultEntity);
            return faixaDtoResult;
        }
    }
}
