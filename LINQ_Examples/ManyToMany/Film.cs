using System.Collections.Generic;

namespace FirstTask.ManyToMany
{
    public class Film
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Actor> Actors { get; set; }
    }
}
