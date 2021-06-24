using System;

namespace Api.WebMusic.Domain.Entities
{
    public class Faixa /* : BaseEntity*/
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Nullable<int> AlbumId { get; set; }
        public Album Album { get; set; }
        public int TipoMidiaId { get; set; }
        public Midia Midia { get; set; }
        public Nullable<int> GeneroId { get; set; }
        public Genero Genero { get; set; }
        public string Compositor { get; set; }
        public int? Millisegundos { get; set; }
        public Int32 Bytes { get; set; }
        public decimal PreçoUnitario { get; set; }


    }
}



