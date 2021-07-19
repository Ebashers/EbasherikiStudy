using Microsoft.EntityFrameworkCore;
using EFKinopoisk5.Models;
using System.Collections.Generic;

namespace EFKinopoisk5.DB
{
    public class MyDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Task6;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>().HasMany(f => f.Actors).WithMany(a => a.Films).UsingEntity(af => af.ToTable("ActorFilms"));

            modelBuilder.Entity<Actor>().ToTable("Actors");

            modelBuilder.Entity<Film>().ToTable("Films");
        }
    }

}
