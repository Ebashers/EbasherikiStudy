using Kinopoisk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Interfaces
{
    public interface IFilm
    {
        IEnumerable<Film> Films { get; }
    }
}
