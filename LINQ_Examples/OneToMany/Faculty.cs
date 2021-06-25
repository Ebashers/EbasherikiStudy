using System.Collections.Generic;

namespace FirstTask.OneToMany
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
    }
}
