using Api.WebMusic.Domain.Dtos.Albuns;
using System.Collections.Generic;

namespace Api.WebMusic.Domain.Dtos.Artistas
{
    public class ArtistaDtoCompleto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<AlbumDtoCompleto> Album { get; set; }
    }
}
