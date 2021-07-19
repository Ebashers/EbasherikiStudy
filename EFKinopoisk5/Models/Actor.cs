using System.Collections.Generic;

namespace EFKinopoisk5.Models
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; } = new List<Film>();
    }
}
