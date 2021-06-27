using Kinopoisk.Models;
using System.Collections.Generic;

namespace Kinopoisk.Interfaces
{
    public interface IActor
    {
        IEnumerable<Actor> Actors { get; }
    }
}
