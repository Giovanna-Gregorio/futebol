using Microsoft.EntityFrameworkCore;
using Fut.Models;
namespace Fut
{
    public class FutContext : DbContext
    {
        public FutContext(DbContextOptions<FutContext> options) : base (options)
        {
            
        }
        public DbSet<Time> Time { get; set; }
        public DbSet<Jogador> Jogador { get; set; }
    }
}