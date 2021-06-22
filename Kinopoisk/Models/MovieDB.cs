using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Models
{
    public class MovieDB
    {
        public int Id { get; set; }
        public List<Actor> Actors { get; set; }
        public List<Film> Films { get; set; }
    }
}
