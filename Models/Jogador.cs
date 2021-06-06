namespace Fut.Models
{
    public class Jogador
    {
        public long Id {get; set;}

        public string Nome {get; set;}

        public int Idade {get; set;}

        public string Posicao {get; set;}

        public long TimeId { get; set; }
        public Time Time {get; set;}
    }
}