using System.Collections.Generic;

namespace Kinopoisk.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ActorFilm> ActorFilms { get; set; }
    }
}
