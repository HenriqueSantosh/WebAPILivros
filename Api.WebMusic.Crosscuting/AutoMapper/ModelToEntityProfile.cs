using Api.WebMusic.Domain.Entities;
using Api.WebMusic.Domain.Models;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Crosscuting.AutoMapper
{
    public class ModelToEntityProfile : Profile
    {
        public ModelToEntityProfile()
        {
            CreateMap<Faixa, FaixaModel>()
                .ReverseMap();

            CreateMap<Midia, MidiaModel>()
                .ReverseMap();

            CreateMap<Artista, ArtistaModel>()
                .ReverseMap();

            CreateMap<Album, AlbumModel>()
                .ReverseMap();

            CreateMap<Genero, GeneroModel>()
                .ReverseMap();
        }
    }
}
