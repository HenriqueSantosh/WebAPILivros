using Api.WebMusic.Domain.Dtos.Albuns;
using Api.WebMusic.Domain.Dtos.Artistas;
using Api.WebMusic.Domain.Dtos.Faixas;
using Api.WebMusic.Domain.Dtos.Generos;
using Api.WebMusic.Domain.Dtos.Midias;
using Api.WebMusic.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Crosscuting.AutoMapper
{
    public class DtoToModelProfile : Profile
    {
        public DtoToModelProfile()
        {
            #region Faixa Mapper
            CreateMap<FaixaModel, FaixaDto>()
                .ReverseMap();

            CreateMap<FaixaModel, FaixaDtoCreate>()
                .ReverseMap();

            CreateMap<FaixaModel, FaixaDtoUpdate>()
                .ReverseMap();
            #endregion

            #region Midia Mapper

            CreateMap<MidiaModel, MidiaDto>()
              .ReverseMap();

            CreateMap<MidiaModel, MidiaDtoCreate>()
                .ReverseMap();

            CreateMap<MidiaDtoUpdate, MidiaModel>()
                .ReverseMap();

            #endregion

            #region Artista Mapper

            CreateMap<ArtistaModel, ArtistaDto>()
                .ReverseMap();

            CreateMap<ArtistaModel, ArtistaDtoCreate>()
                .ReverseMap();

            CreateMap<ArtistaModel, ArtistaDtoUpdate>()
                .ReverseMap();
            #endregion

            #region Album Mapper

            CreateMap<AlbumModel, AlbumDto>()
                .ReverseMap();

            CreateMap<AlbumModel, AlbumDtoCreate>()
                .ReverseMap();

            CreateMap<AlbumModel, AlbumDtoUpdate>()
                .ReverseMap();
            #endregion

            #region Genero Mapper

            CreateMap<GeneroModel, GeneroDto>()
                .ReverseMap();

            CreateMap<GeneroModel, GeneroDtoCreate>()
                .ReverseMap();

            CreateMap<GeneroModel, GeneroDtoUpdate>()
                .ReverseMap();
            #endregion
        }
    }
}
