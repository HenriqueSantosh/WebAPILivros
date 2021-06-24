using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Domain.Dtos.Albuns
{
    public class AlbumDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int ArtistaId { get; set; }
    }
}
