
namespace University.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int GradebookId { get; set; }    // айді заліковки, not a real ID
        public double GPA { get; set; }         // середній бал
        public Faculty Faculty { get; set; }
        public int FacultyId { get; set; }
    }
}
