using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Domain.Entities
{
    public class Album /*: BaseEntity*/
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int ArtistaId { get; set; }
        public Artista Artista { get; set; }
        public IEnumerable<Faixa> Faixas { get; set; }

        public Album()
        {
            Faixas = new List<Faixa>();
        }
    }
}

/*public int AlbumId { get; set; }
public string Titulo { get; set; }

public virtual Artista Artista { get; set; }
[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
public virtual ICollection<Faixa> Faixas { get; set; }*/
