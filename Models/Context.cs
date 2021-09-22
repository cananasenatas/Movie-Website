using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebSite.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-N1UQOJ3H; database=MovieWeb; integrated security=true");

        }

        public DbSet<Website> Website { get; set; }
        public DbSet<Genres> Genres { get; set; }
        public DbSet<Choose> Choose { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Filter> Filter { get; set; }
        public DbSet<AppUser> AppUser { get; set; }
    }
}
