using System.Collections.Generic;

namespace FirstTask.ManyToMany
{
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Film> Films { get; set; }
    }
}
