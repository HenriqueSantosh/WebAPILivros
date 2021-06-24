using Api.WebMusic.Domain.Dtos.Albuns;
using Api.WebMusic.Domain.Dtos.Artistas;
using Api.WebMusic.Domain.Dtos.Faixas;
using Api.WebMusic.Domain.Dtos.Generos;
using Api.WebMusic.Domain.Dtos.Midias;
using Api.WebMusic.Domain.Entities;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Crosscuting.AutoMapper
{
    public class EntityToDtoProfile : Profile
    {
        public EntityToDtoProfile()
        {
            #region Faixa
            CreateMap<Faixa, FaixaDtoCompleto>()
                .ReverseMap();

            CreateMap<Faixa, FaixaDto>()
                .ReverseMap();

            CreateMap<Faixa, FaixaDtoResult>()
                .ReverseMap();
            #endregion

            #region Midia

            CreateMap<Midia, MidiaDto>()
                .ReverseMap();

            CreateMap<Midia, MidiaDtoCompleto>()
             .ReverseMap();
            #endregion

            #region Artista

            CreateMap<Artista, ArtistaDto>()
                .ReverseMap();

            CreateMap<Midia, ArtistaDtoCompleto>()
             .ReverseMap();
            #endregion

            #region Genero

            CreateMap<Genero, GeneroDto>()
                .ReverseMap();

            CreateMap<Genero, GeneroDtoCompleto>()
             .ReverseMap();
            #endregion

            #region Album

            CreateMap<Album, AlbumDto>()
                .ReverseMap();

            CreateMap<Album, AlbumDtoCompleto>()
             .ReverseMap();
            #endregion
        }
    }
}
