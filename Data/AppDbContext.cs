using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Rundenwettkampf.Models;

namespace Rundenwettkampf.Data
{
    internal class AppDbContext : DbContext
    {
        public DbSet<AgeClass> AgeClasses { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Person> Persons => Set<Person>();

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite("Data Source=app.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
