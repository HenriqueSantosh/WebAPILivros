using Api.WebMusic.Domain.Dtos.Artistas;
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
    public class ArtistaService : IArtistaService
    {
        private readonly IArtistaRepository _repository;
        private IMapper _mapper;

        public ArtistaService(IArtistaRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<bool> Delete(int id)
        {
            return await _repository.DeleteAsync(id);
        }

        public async Task<ArtistaDto> Get(int id)
        {
            var artistaEntity = await _repository.SelectAsync(id);
            return _mapper.Map<ArtistaDto>(artistaEntity);
        }

        public async Task<IEnumerable<ArtistaDtoCompleto>> GetAllArtistaCompleto()
        {
            var listArtista = await _repository.GetListCompletoArtista();
            return _mapper.Map<IEnumerable<ArtistaDtoCompleto>>(listArtista);
        }

        public async Task<IEnumerable<ArtistaDto>> GetAllArtistaDto()
        {
            var listArtista = await _repository.SelectAsync();
            return _mapper.Map<IEnumerable<ArtistaDto>>(listArtista);
        }

        public async Task<ArtistaDtoCompleto> GetArtistaByIdCompleto(int id)
        {
            var getEntity = await _repository.GetArtistaCompleto(id);
            return _mapper.Map<ArtistaDtoCompleto>(getEntity);
        }

        public async Task<ArtistaDto> Post(ArtistaDtoCreate artistaDtoCreate)
        {
            var modelArtista = _mapper.Map<ArtistaModel>(artistaDtoCreate);
            var entityArtista = _mapper.Map<Artista>(modelArtista);
            var enityResult = await _repository.InsertAsync(entityArtista);
            return _mapper.Map<ArtistaDto>(enityResult);
        }

        public async Task<ArtistaDto> Put(ArtistaDtoUpdate artistaDtoUpdate)
        {
            var modelArtista = _mapper.Map<ArtistaModel>(artistaDtoUpdate);
            var entityArtista = _mapper.Map<Artista>(modelArtista);
            var enityResult = await _repository.InsertAsync(entityArtista);
            return _mapper.Map<ArtistaDto>(enityResult);
        }
    }
}
