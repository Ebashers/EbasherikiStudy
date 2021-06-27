using System.Collections.Generic;

namespace University.Models
{
    public class Institute
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Faculty> Faculties { get; set; }
    }
}
