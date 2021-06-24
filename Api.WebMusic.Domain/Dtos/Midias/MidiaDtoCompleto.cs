using Api.WebMusic.Domain.Entities;
using System.Collections.Generic;

namespace Api.WebMusic.Domain.Dtos.Midias
{
    public class MidiaDtoCompleto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Faixa> Faixas { get; set; }
        public MidiaDtoCompleto()
        {
            Faixas = new List<Faixa>();
        }
    }
}
