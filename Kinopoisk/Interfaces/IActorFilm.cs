using Kinopoisk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Interfaces
{
    public interface IActorFilm
    {
        IEnumerable<ActorFilm> ActorFilms { get; }
    }
}
