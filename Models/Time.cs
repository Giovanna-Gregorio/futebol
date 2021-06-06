using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Fut.Models
{
    public class Time
    {
        public long Id { get; set; }

        [StringLength(30, MinimumLength = 3), Required]
        public string Nome { get; set; }

        [StringLength(4, MinimumLength = 2), Required]
        public string Abrev { get; set; }

        [StringLength(30, MinimumLength = 3), Required]
        public string Cidade { get; set; }
        public ICollection<Jogador> Jogadores { get; set; }
    }

}