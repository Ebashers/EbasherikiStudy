using Microsoft.EntityFrameworkCore;
using EFKinopoisk.Models;

namespace EFKinopoisk.DB
{
    public class MyDbContext : DbContext
    {
        public DbSet<Actor> Actors { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<ActorFilm> ActorFilms { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Task6;Trusted_Connection=True;");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActorFilm>().HasKey(af => new { af.ActorId, af.FilmId });
            modelBuilder.Entity<ActorFilm>().HasOne(af => af.Actor).WithMany(a => a.ActorFilms).HasForeignKey(af => af.ActorId);
            modelBuilder.Entity<ActorFilm>().HasOne(af => af.Film).WithMany(f => f.ActorFilms).HasForeignKey(af => af.FilmId);

            modelBuilder.Entity<Actor>().ToTable("Actors");
            modelBuilder.Entity<Actor>().HasData(
                new Actor { Id = 1, Name = "Biba" },
                new Actor { Id = 2, Name = "Boba" },
                new Actor { Id = 3, Name = "Ebanko" },
                new Actor { Id = 4, Name = "KolaCation" }
                );

            modelBuilder.Entity<Film>().ToTable("Films");
            modelBuilder.Entity<Film>().HasData(
                new Film { Id = 1, Name = "Dva dolboyoba" },
                new Film { Id = 2, Name = "Ya ebu sobak" },
                new Film { Id = 3, Name = "Super crossover" }
                );

            modelBuilder.Entity<ActorFilm>().ToTable("ActorFilms");
            modelBuilder.Entity<ActorFilm>().HasData(
                new ActorFilm { ActorId = 1, FilmId = 1 },
                new ActorFilm { ActorId = 1, FilmId = 3 },
                new ActorFilm { ActorId = 2, FilmId = 1 },
                new ActorFilm { ActorId = 2, FilmId = 3 },
                new ActorFilm { ActorId = 3, FilmId = 2 },
                new ActorFilm { ActorId = 3, FilmId = 3 }
                );
        }
    }
}
