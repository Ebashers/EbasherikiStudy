using Kinopoisk.Models;
using System.Collections.Generic;

namespace Kinopoisk.Interfaces
{
    public interface IFilm
    {
        IEnumerable<Film> Films { get; }
    }
}
