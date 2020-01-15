using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Julero.Models;

namespace Julero.Data
{
    public class JuleroContext : DbContext
    {
        public JuleroContext (DbContextOptions<JuleroContext> options)
            : base(options)
        {
        }

        public DbSet<Julero.Models.Goal> Goal { get; set; }
    }
}
