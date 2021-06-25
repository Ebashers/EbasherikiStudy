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
            var movieDB = new MockMovieDB().MovieDBs;

            //Я їбав тупить над селектом в цьому варіанті

            //var conn = actors.Join(movieDB, actors => actors.Id, movieDB => movieDB.ActorId, (actor, moviedb) => new ActorFilm
            //{
            //    Id = moviedb.Id,
            //    ActorId = actor.Id,
            //    FilmId = moviedb.FilmId,
            //    Films = actor.ToList()

            //}).Join(films, movieDB => movieDB.FilmId, films => films.Id, (moviedb, film) => new ActorFilm
            //{
            //    Id = moviedb.Id,
            //    ActorId = moviedb.ActorId,
            //    FilmId = film.Id

            //}).Select(actor => actor.ActorId);

            //First task
            foreach (var a in actors)
            {
                if (!movieDB.Any(x => x.ActorId == a.Id))
                {
                    Console.WriteLine(a.Name);
                }
            }
            Console.WriteLine();

            //Second task
            var firstActor = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            var connection = (from actor in actors
                             join actorFilm in movieDB on actor.Id equals actorFilm.ActorId
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
                else Console.WriteLine("Fuck u");
            }

            //Third task
            var repeat = connection.GroupBy(FilmName => FilmName).Where(connection => connection.Count() > 1).Select(r => new { Element = r.Key, Counter = r.Count() }).ToList();
            var max = repeat.Max(r => r.Counter);
            var maxFilm = connection.GroupBy(FilmName => FilmName).Where(connection => connection.Count() == max).ToList();

            foreach (var m in maxFilm)
            {
                Console.WriteLine(m.Key);
            }
            Console.WriteLine(maxFilm);
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}