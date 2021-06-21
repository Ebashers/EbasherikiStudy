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
            var StudentsConnection = f.GroupJoin(s, f => f.Id, s => s.FacultyId, (faculties, students) => new Faculty { Id = faculties.Id, Name = faculties.Name, Students = students.ToList() });
            var FacultiesConnection = i.GroupJoin(f, i => i.Id, f => f.InstituteId, (institute, faculties) => new Institute { Id = institute.Id, Name = institute.Name, Faculties = faculties.ToList() });
            
            Console.WriteLine(s.Count());
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
