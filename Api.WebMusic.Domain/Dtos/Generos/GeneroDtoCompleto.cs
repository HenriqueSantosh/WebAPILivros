using Api.WebMusic.Domain.Entities;
using System.Collections.Generic;

namespace Api.WebMusic.Domain.Dtos.Generos
{
    public class GeneroDtoCompleto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Faixa> Faixas { get; set; }

        public GeneroDtoCompleto()
        {
            Faixas = new List<Faixa>();
        }
    }
}
