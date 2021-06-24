using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinopoisk.Models
{
    public class ActorFilm
    {
        public int Id { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
        public List<Actor> Actors { get; set; }
        public Film Film { get; set; }
        public int FilmId { get; set; }
        public List<Film> Films { get; set; }
    }
}
