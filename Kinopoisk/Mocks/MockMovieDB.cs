using Kinopoisk.Interfaces;
using Kinopoisk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Mocks
{
    public class MockMovieDB : IMovieDB
    {
        public IEnumerable<ActorFilm> MovieDBs
        {
            get
            {
                return new List<ActorFilm>
                {
                    new ActorFilm
                    {
                        Id = 1,
                        FilmId = 1,
                        ActorId = 1
                    },
                    new ActorFilm
                    {
                        Id = 2,
                        FilmId = 1,
                        ActorId = 2
                    },
                    new ActorFilm
                    {
                        Id = 3,
                        FilmId = 2,
                        ActorId = 3
                    },
                    new ActorFilm
                    {
                        Id = 4,
                        FilmId = 3,
                        ActorId = 1
                    },
                    new ActorFilm
                    {
                        Id = 5,
                        FilmId = 3,
                        ActorId = 2
                    },
                    new ActorFilm
                    {
                        Id = 6,
                        FilmId = 3,
                        ActorId = 3
                    }
                };
            }
        }
    }
}
