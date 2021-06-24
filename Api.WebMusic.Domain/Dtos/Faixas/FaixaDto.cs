using Api.WebMusic.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Domain.Dtos.Faixas
{
    public class FaixaDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int GeneroId { get; set; }
        public int AlbumId { get; set; }
        public int TipoMidiaId { get; set; }
        public string Compositor { get; set; }
        public int? Millisegundos { get; set; }
        public Int32 Bytes { get; set; }
        public decimal PreçoUnitario { get; set; }
    }
}
