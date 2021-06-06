using System.Collections.Generic;

namespace Fut.Models
{
    public class Time
    {
        public long Id { get; set; }

        public string Nome { get; set; }

        public string Abrev { get; set; }

        public string Cidade { get; set; }

        public ICollection<Jogador> Jogadores { get; set; }
    }

}