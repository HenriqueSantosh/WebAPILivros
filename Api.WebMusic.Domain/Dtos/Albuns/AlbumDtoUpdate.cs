using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.WebMusic.Domain.Dtos.Albuns
{
    public class AlbumDtoUpdate
    {
        [Required(ErrorMessage = "O Id é campo Obrigatorio")]
        public int Id { get; set; }

        [Required(ErrorMessage = "O Titulo é Campo Obrigatorio")]
        public string Titulo { get; set; }

        [Required(ErrorMessage = "O Artista é Campo Obrigatorio")]
        public int ArtistaId { get; set; }

    }
}
