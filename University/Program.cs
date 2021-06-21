using System;
using System.Linq;
using University.Interfaces;
using University.Mocks;
using University.Models;

namespace University
{
    class Program
    {
        static void Main(string[] args)
        {
            var i = new MockInstitute().Institutes;
            var f = new MockFaculty().Faculties;
            var s = new MockStudent().Students;

            var MaxStudents = s.Where(s => s.GPA > 95).ToList();
            Console.WriteLine("Students with GPA > 95:");
            foreach (var student in MaxStudents)
            {
                Console.WriteLine(student.Name + " " + student.Surname + " " + student.GPA);
            }
            Console.WriteLine();

            var StudentsConnection = f.GroupJoin(s, f => f.Id, s => s.FacultyId, (faculties, students) => new Faculty { Id = faculties.Id, Name = faculties.Name, Students = students.ToList() });
            var MaxFaculty = StudentsConnection.Max(f => f.Students.Count);
            var MaxFacultyName = StudentsConnection.Where(f => f.Students.Count == MaxFaculty).ToList();
            Console.WriteLine("Faculties with the biggest amount of students:");
            foreach (var faculty in MaxFacultyName)
            {
                Console.WriteLine(faculty.Name);
            }
            Console.WriteLine();

            Console.WriteLine("All students amount:");
            var FacultiesConnection = i.GroupJoin(f, i => i.Id, f => f.InstituteId, (institute, faculties) => new Institute { Id = institute.Id, Name = institute.Name, Faculties = faculties.ToList() });
            Console.WriteLine(s.Count());

            Console.ReadKey();
        }
    }
}
