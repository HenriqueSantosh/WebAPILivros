using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Domain.Models
{
    public class FaixaModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        private string _compositor;
        public string Compositor
        {
            get { return _compositor; }
            set { _compositor = string.IsNullOrWhiteSpace(value) ? "Autor Desconhecido" : value; }
        }
        public int Millisegundos { get; set; }
        public Int32 Bytes { get; set; }
        public decimal PreçoUnitario { get; set; }
        public int GeneroId { get; set; }
        public int AlbumId { get; set; }
        public int TipoMidiaId { get; set; }
    }
}
