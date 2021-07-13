using EFKinopoisk.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFKinopoisk
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new MyDbContext();
            await context.Database.MigrateAsync();
            var actors = await context.Actors.ToListAsync();
            var actorFilms = await context.ActorFilms.ToListAsync();
            var films = await context.Films.ToListAsync();

            Console.WriteLine("Actor without film");
            foreach (var a in actors)
            {
                if (!actorFilms.Any(af => af.ActorId == a.Id))
                {
                    Console.WriteLine(a.Name);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Enter the name of the actor");
            var firstActor = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("All actor's films and another films' actors");
            var selectedFilms = actorFilms.Where(c => c.Actor.Name.ToLower() == firstActor.ToLower()).Select(f => f.FilmId).ToList();
            foreach (var sf in selectedFilms)
            {
                var thisActors = actorFilms.Where(c => c.FilmId == sf).Select(c => c.Actor.Name).ToList();
                var thisFilms = films.Where(f => f.Id == sf).Select(f => f.Name).ToList();
                thisFilms.ForEach(film => Console.WriteLine(film));
                thisActors.ForEach(filmActor => Console.WriteLine(filmActor));
                Console.WriteLine();
            }

            Console.WriteLine("Film with the biggest amount of actors");
            var filmCounts = await context.Films.Select(f => f.ActorFilms.Count).ToListAsync();
            var maxFilm = filmCounts.Max();
            var maxFilmName = await context.Films.Where(f => f.ActorFilms.Count == maxFilm).ToListAsync();
            maxFilmName.ForEach(m => Console.WriteLine(m.Name));
            Console.WriteLine();
        }
    }
}
