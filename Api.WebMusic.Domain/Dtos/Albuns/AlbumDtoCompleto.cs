using Api.WebMusic.Domain.Entities;
using System.Collections.Generic;

namespace Api.WebMusic.Domain.Dtos.Albuns
{
    public class AlbumDtoCompleto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int ArtistaId { get; set; }
        public  Artista Artista { get; set; }
        public IEnumerable<Faixa> Faixas { get; set; }

        public AlbumDtoCompleto()
        {
            Faixas = new List<Faixa>();
        }
    }
}
