using System.ComponentModel.DataAnnotations;

namespace Fut.Models
{
    public class Jogador
    {
        public long Id {get; set;}

        [StringLength(60, MinimumLength = 3), Required]
        public string Nome {get; set;}

        [Required]
        public int Idade {get; set;}

        [StringLength(30, MinimumLength = 3), Required]
        public string Posicao {get; set;}

        [Required, Display(Name = "Time")]
        public long TimeId { get; set; }
        public Time Time {get; set;}
    }
}