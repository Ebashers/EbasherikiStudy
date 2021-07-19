using System.Collections.Generic;

namespace EFKinopoisk5.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Actor> Actors { get; set; } = new List<Actor>();
    }
}
