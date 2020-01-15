using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Julero.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Julero.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new JuleroContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<JuleroContext>>()))
            {
                // Look for any movies.
                if (context.Goal.Any())
                {
                    return;   // DB has been seeded
                }

                context.Goal.AddRange(
                    new Goal
                    {
                        name = "Learn how to use Julero",
                        startDate = DateTime.Now,
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
