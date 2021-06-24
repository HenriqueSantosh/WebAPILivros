using Api.WebMusic.Domain.Dtos.Albuns;
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
    public class AlbumService : IAlbumService
    {

        private readonly IAlbumRepository _repository;
        private IMapper _mapper;

        public AlbumService(IAlbumRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<AlbumDto> Get(int id)
        {
            var entity = await _repository.SelectAsync(id);
            return _mapper.Map<AlbumDto>(entity);
        }

        public async Task<AlbumDtoCompleto> GetAlbumByIdCompleto(int id)
        {
            var entity = await _repository.GetAlbumCompleto(id);
            return _mapper.Map<AlbumDtoCompleto>(entity);
        }

        public async Task<IEnumerable<AlbumDtoCompleto>> GetAllAlbumCompleto()
        {
            var listEntity = await _repository.GetAllAlbumCompletos();
            return _mapper.Map<IEnumerable<AlbumDtoCompleto>>(listEntity);
        }

        public async Task<IEnumerable<AlbumDto>> GetAllAlbumDto()
        {
            var listEntity = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<AlbumDto>>(listEntity);
        }

        public async Task<AlbumDto> Post(AlbumDtoCreate albumDtoCreate)
        {
            var model = _mapper.Map<AlbumModel>(albumDtoCreate);
            var entity = _mapper.Map<Album>(model);
            var result = await _repository.InsertAsync(entity);
            return _mapper.Map<AlbumDto>(result);
        }

        public async Task<AlbumDto> Put(AlbumDtoUpdate albumDtoUpdate)
        {
            var model = _mapper.Map<AlbumModel>(albumDtoUpdate);
            var entity = _mapper.Map<Album>(model);
            var result = await _repository.UpdateAsync(entity);
            return _mapper.Map<AlbumDto>(result);
        }
    }
}
