using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.WebMusic.Domain.Dtos.Generos
{
   public  class GeneroDtoCreate
    {
        [Required(ErrorMessage = "O Nome do Genero é Campo Obrigatorio")]
        public string Nome { get; set; }
    }
}
