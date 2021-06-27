using Kinopoisk.Interfaces;
using Kinopoisk.Models;
using System.Collections.Generic;

namespace Kinopoisk.Mocks
{
    public class MockActor : IActor
    {
        public IEnumerable<Actor> Actors
        {
            get
            {
                return new List<Actor>
                {
                    new Actor
                    {
                        Id = 1,
                        Name = "Biba"
                    },
                    new Actor
                    {
                        Id = 2,
                        Name = "Boba"
                    },
                    new Actor
                    {
                        Id = 3,
                        Name = "Ebanko"
                    },
                    new Actor
                    {
                        Id = 4,
                        Name = "Kekos"
                    }
                };
            }
        }
    }
}
