using System;
using System.Linq;
using University.Mocks;
using University.Models;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            var institute = new MockInstitute().Institutes;
            var faculty = new MockFaculty().Faculties;
            var students = new MockStudent().Students;

            var MaxStudents = students.Where(students => students.GPA > 95).ToList();
            Console.WriteLine("Students with GPA > 95:");
            foreach (var student in MaxStudents)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.GPA);
            }
            Console.WriteLine();

            var StudentsConnection = faculty.GroupJoin(students, faculty => faculty.Id, students => students.FacultyId, (faculties, students) => new Faculty { Id = faculties.Id, Name = faculties.Name, Students = students.ToList() });
            var MaxFaculty = StudentsConnection.Max(faculty => faculty.Students.Count);
            var MaxFacultyName = StudentsConnection.Where(faculty => faculty.Students.Count == MaxFaculty).ToList();
            Console.WriteLine("Faculties with the biggest amount of students:");
            foreach (var f in MaxFacultyName)
            {
                Console.WriteLine(f.Name);
            }
            Console.WriteLine();

            Console.WriteLine("All students amount:");
            var FacultiesConnection = institute.GroupJoin(faculty, institute => institute.Id, faculty => faculty.InstituteId, (institute, faculties) => new Institute { Id = institute.Id, Name = institute.Name, Faculties = faculties.ToList() });
            Console.WriteLine(students.Count());

            Console.ReadKey();
        }
    }
}
