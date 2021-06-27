using Kinopoisk.Interfaces;
using Kinopoisk.Models;
using System.Collections.Generic;

namespace Kinopoisk.Mocks
{
    public class MockFilm : IFilm
    {
        public IEnumerable<Film> Films
        {
            get
            {
                return new List<Film>
                {
                    new Film
                    {
                        Id = 1,
                        Name = "Biba i Boba"
                    },
                    new Film
                    {
                        Id = 2,
                        Name = "Ya ebu sobak"
                    },
                    new Film
                    {
                        Id = 3,
                        Name = "Super crossover"
                    }
                };
            }
        }
    }
}
