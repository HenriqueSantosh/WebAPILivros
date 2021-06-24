using Api.WebMusic.Domain.Entities;
using System;
using System.Collections.Generic;

namespace Api.WebMusic.Domain.Dtos.Faixas
{
    public class FaixaDtoCompleto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Album Album { get; set; }
        public Midia Midia { get; set; }
        public Genero Genero { get; set; }
        public string Compositor { get; set; }
        public int? Millisegundos { get; set; }
        public Int32 Bytes { get; set; }
        public decimal PreçoUnitario { get; set; }
    }
}
