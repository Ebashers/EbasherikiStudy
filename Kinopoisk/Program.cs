using System;
using System.Linq;
using Kinopoisk.Mocks;
using Kinopoisk.Models;

namespace Kinopoisk
{
    class Program
    {
        static void Main(string[] args)
        {
            var actors = new MockActor().Actors;
            var films = new MockFilm().Films;
            var actorFilms = new MockActorFilm().ActorFilms;

            //Я їбав тупить над селектом в цьому варіанті

            //var conn = actors.Join(actorFilms, actors => actors.Id, actorFilms => actorFilms.ActorId, (actor, actorFilm) => new ActorFilm
            //{
            //    Id = actorFilm.Id,
            //    ActorId = actor.Id,
            //    FilmId = actorFilm.FilmId,

            //}).Join(films, actorFilms => actorFilms.FilmId, films => films.Id, (actorFilm, film) => new ActorFilm
            //{
            //    Id = actorFilm.Id,
            //    ActorId = actorFilm.ActorId,
            //    FilmId = film.Id

            //}).Select(s => new { s, FilmName = film.Name, ActorName = actor.Name }).ToList();

            //First task
            Console.WriteLine("Actor without film");
            foreach (var a in actors)
            {
                if (!actorFilms.Any(x => x.ActorId == a.Id))
                {
                    Console.WriteLine(a.Name);
                }
            }
            Console.WriteLine();

            //Second task
            Console.WriteLine("Enter the name of the actor");
            var firstActor = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("All actor's films and another films' actors");
            var connection = (from actor in actors
                             join actorFilm in actorFilms on actor.Id equals actorFilm.ActorId
                             join film in films on actorFilm.FilmId equals film.Id
                             select new { FilmName = film.Name, ActorName = actor.Name }).ToList();

            foreach (var c in connection)
            {
                if (firstActor == c.ActorName)
                {
                    var thisFilms = connection.Where(c => c.ActorName == firstActor).Select(c => c.FilmName).ToList();
                    foreach (var t in thisFilms)
                    {
                        var thisActors = connection.Where(c => c.FilmName == t).Select(c => c.ActorName).ToList();
                        Console.WriteLine(t);
                        foreach (var filmActor in thisActors)
                        {
                            Console.WriteLine(filmActor);
                        }
                        Console.WriteLine();
                    }
                }
            }
            Console.WriteLine();

            //Third task
            Console.WriteLine("Film with the biggest amount of actors");
            var max = connection.Max(c => c.FilmName.Count());
            var maxFilm = connection.Where(c => c.FilmName.Count() == max).ToList();
            foreach (var m in maxFilm)
            {
                Console.WriteLine(m);
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}