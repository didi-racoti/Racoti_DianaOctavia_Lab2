using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Racoti_DianaOctavia_Lab2.Models;

namespace Racoti_DianaOctavia_Lab2.Data
{
    public class Racoti_DianaOctavia_Lab2Context : DbContext
    {
        public Racoti_DianaOctavia_Lab2Context (DbContextOptions<Racoti_DianaOctavia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Racoti_DianaOctavia_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Racoti_DianaOctavia_Lab2.Models.Publisher>? Publisher { get; set; }

        public DbSet<Racoti_DianaOctavia_Lab2.Models.Author>? Author { get; set; }
    }
}
