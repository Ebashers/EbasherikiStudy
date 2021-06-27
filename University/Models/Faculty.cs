using System.Collections.Generic;

namespace University.Models
{
    public class Faculty
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Institute Institute { get; set; }
        public int InstituteId { get; set; }
        public List<Student> Students { get; set; }
    }
}
