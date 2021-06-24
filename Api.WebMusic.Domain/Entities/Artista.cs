using System.Collections.Generic;

namespace Api.WebMusic.Domain.Entities
{
    public class Artista /*: BaseEntity*/
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Album> Album { get; set; }

    }
}