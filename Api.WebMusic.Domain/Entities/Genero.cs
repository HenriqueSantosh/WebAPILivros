using System.Collections.Generic;

namespace Api.WebMusic.Domain.Entities
{
    public class Genero
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Faixa> Faixas { get; set; }

        public Genero()
        {
            Faixas = new List<Faixa>();
        }
    }
}