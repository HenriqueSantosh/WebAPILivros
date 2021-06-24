using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Api.WebMusic.Domain.Dtos.Faixas
{
    public class FaixaDtoCreate
    {
        [Required(ErrorMessage ="O Titulo da Faixa é Obrigatorio")]
        [StringLength(220, ErrorMessage = "Nome da Faixa deve ter no maximo 220 caracteres")]
        public string Nome { get; set; }
        public int GeneroId { get; set; }
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "O codigo da faixa é obrigatorio")]
        public int TipoMidiaId { get; set; }
        public string Compositor { get; set; }

        [Required(ErrorMessage = "O tempo da duração da faixa")]
        [Range(0, int.MaxValue, ErrorMessage = "Millisegundos Invalido")]
        public int Millisegundos { get; set; }
        public Int32 Bytes { get; set; }

        [Required]
        public decimal PreçoUnitario { get; set; }
    }
}
