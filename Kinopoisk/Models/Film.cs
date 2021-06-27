using System.Collections.Generic;

namespace Kinopoisk.Models
{
    public class Film
    {
        // взагалі правильно movie, film то плівка. но я довбойоб, мені пох
        public int Id { get; set; }
        public string Name { get; set; }
        public List<ActorFilm> ActorFilms { get; set; }
    }
}
