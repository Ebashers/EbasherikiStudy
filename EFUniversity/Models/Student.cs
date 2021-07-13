using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFUniversity.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GradebookNumber { get; set; }
        public double Grade { get; set; }
        public Faculty Faculty { get; set; }
        public int FacultyId { get; set; }
    }
}
