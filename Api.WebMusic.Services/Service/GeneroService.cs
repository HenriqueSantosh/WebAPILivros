using Api.WebMusic.Domain.Dtos.Generos;
using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Interfaces.Services;
using Api.WebMusic.Domain.Models;
using Api.WebMusic.Domain.Repository;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Api.WebMusic.Services.Service
{
    public class GeneroService : IGeneroService
    {
        private readonly IGeneroRepository _repository;
        private IMapper _mapper;

        public GeneroService(IGeneroRepository repository, IMapper imapper)
        {
            _repository = repository;
            _mapper = imapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<GeneroDto> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<GeneroDto>(entity);
        }

        public async Task<IEnumerable<GeneroDtoCompleto>> GetAllGeneroCompleto()
        {
            var listGenero = await _repository.SelectCompletoGenero();
            return _mapper.Map<IEnumerable<GeneroDtoCompleto>>(listGenero);
        }

        public async Task<IEnumerable<GeneroDto>> GetAllGeneroDto()
        {
            var listGenero = await _repository.SelectCompletoGenero();
            return _mapper.Map<IEnumerable<GeneroDto>>(listGenero);
        }

        public async Task<GeneroDtoCompleto> GetGeneroByIdCompleto(int id)
        {
            var entityGenero = await _repository.GetGeneroCompleto(id);
            return _mapper.Map<GeneroDtoCompleto>(entityGenero);
        }

        public async Task<GeneroDto> Post(GeneroDtoCreate albumDtoCreate)
        {
            var modelGenero = _mapper.Map<GeneroModel>(albumDtoCreate);
            var entityGenero = _mapper.Map<Genero>(modelGenero);
            var enityResult = await _repository.InsertAsync(entityGenero);
            return _mapper.Map<GeneroDto>(enityResult);
        }

        public async Task<GeneroDto> Put(GeneroDtoUpdate albumDtoUpdate)
        {
            var modelGenero = _mapper.Map<GeneroModel>(albumDtoUpdate);
            var entityGenero = _mapper.Map<Genero>(modelGenero);
            var enityResult = await _repository.UpdateAsync(entityGenero);
            return _mapper.Map<GeneroDto>(enityResult);
        }
    }
}
