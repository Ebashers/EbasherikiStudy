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

            /*
            
            Я їбав тупить над селектом в цьому варіанті

            var conn = actors.Join(movieDB, actors => actors.Id, movieDB => movieDB.ActorId, (actor, moviedb) => new
            {
                Id = moviedb.Id,
                ActorId = actor.Id,
                FilmId = moviedb.FilmId

            }).Join(films, movieDB => movieDB.FilmId, films => films.Id, (moviedb, film) => new
            {
                Id = moviedb.Id,
                ActorId = moviedb.ActorId,
                FilmId = film.Id

            }).SelectMany(movieDB, actors => actors.Name, films => films.Name);
            */

            var connection = from actor in actors
                             join actorFilm in movieDB on actor.Id equals actorFilm.ActorId
                             join film in films on actorFilm.FilmId equals film.Id
                             select $"{actor.Name} {film.Name}";

            foreach (var a in actors)
            {
                if (!movieDB.Any(x => x.ActorId == a.Id))
                {
                    Console.WriteLine(a.Name);
                }
            }

            var max = from actor in actors
                             join actorFilm in movieDB on actor.Id equals actorFilm.ActorId
                             join film in films on actorFilm.FilmId equals film.Id
                             select actor.Name.Max();

        }
    }
}