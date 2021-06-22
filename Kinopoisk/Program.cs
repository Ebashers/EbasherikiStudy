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
            var a = new MockActor().Actors;
            var f = new MockFilm().Films;
            var m = new MockMovieDB().MovieDBs;

        }
    }
}