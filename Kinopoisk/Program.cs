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


            var connection = from actor in actors
                             join actorFilm in movieDB on actor.Id equals actorFilm.ActorId
                             join film in films on actorFilm.FilmId equals film.Id
                             select actor.Name + film.Name + actor.Id + film.Id;

            foreach (var a in actors)
            {
                if (!movieDB.Any(x => x.ActorId == a.Id))
                {
                    Console.WriteLine(a.Name);
                }
            }
            Console.WriteLine();

            var repeat = connection.GroupBy(actor => actor).Where(film => film.Count() > 1).Select(r => new { Element = r.Key, Counter = r.Count() }).ToList();
            var max = repeat.Max(r => r.Counter);
            var maxFilm = connection.Where(actor => actor.Count() == max).ToList();

            Console.WriteLine(maxFilm);
            //var max = from actor in actors
            //                 join actorFilm in movieDB on actor.Id equals actorFilm.ActorId
            //                 join film in films on actorFilm.FilmId equals film.Id
            //                 select actor.Name.Count();

            //var maxFilm = connection.Where(actor => actor. == max).ToList();
        }
    }
}