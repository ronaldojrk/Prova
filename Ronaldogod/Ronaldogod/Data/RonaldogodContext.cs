using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ronaldogod.Models;

namespace Ronaldogod.Models
{
    public class RonaldogodContext : DbContext
    {
        public RonaldogodContext (DbContextOptions<RonaldogodContext> options)
            : base(options)
        {
        }

        public DbSet<Ronaldogod.Models.Jogador> Jogador { get; set; }

        public DbSet<Ronaldogod.Models.Placar> Placar { get; set; }
    }
}
