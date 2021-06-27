using Kinopoisk.Models;
using System.Collections.Generic;

namespace Kinopoisk.Interfaces
{
    public interface IActorFilm
    {
        IEnumerable<ActorFilm> ActorFilms { get; }
    }
}
