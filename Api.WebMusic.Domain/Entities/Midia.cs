using System.Collections.Generic;

namespace Api.WebMusic.Domain.Entities
{
    public class Midia
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IEnumerable<Faixa> Faixas { get; set; }

        public Midia()
        {
            Faixas = new List<Faixa>();
        }
    }
}