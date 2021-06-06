using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Fut.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FutContext(
                serviceProvider.GetRequiredService<DbContextOptions<FutContext>>()))
            {
                if (context.Time.Any())
                    return;
                
                context.Time.AddRange(
                    new Time
                    {
                        Nome = "Barcelona",
                        Abrev = "BAR",
                        Cidade = "Barcelona"
                    },
                    new Time
                    {
                        Nome = "Real Madrid",
                        Abrev = "REM",
                        Cidade = "Madrid"
                    }
                );

                context.SaveChanges();
            };
        }
    }
}