using System;
using System.Collections.Generic;
using System.Text;

namespace Api.WebMusic.Domain.Models
{
    public class AlbumModel
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int ArtistaId { get; set; }
    }
}
