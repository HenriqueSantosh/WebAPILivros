using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.WebMusic.Domain.Dtos.Midias
{
    public class MidiaDtoCreate
    {
        [Required(ErrorMessage = "O Nome da Midia é Campo Obrigatorio")]
        public string Nome { get; set; }
    }
}
