using EFUniversity.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFUniversity
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new MyDbContext();
            await context.Database.MigrateAsync();
            var students = await context.Students.ToListAsync();

            Console.WriteLine("All students amount:");
            Console.WriteLine(students.Count);
            Console.WriteLine();

            var gradedStudents = students.Where(students => students.Grade > 95).ToList();
            Console.WriteLine("Students with GPA > 95:");
            gradedStudents.ForEach(s => Console.WriteLine(s.Name + " " + s.Surname + " " + s.Grade));
            Console.WriteLine();

            var facultyStudents = await context.Faculties.Select(f => f.Students.Count).ToListAsync();
            var maxStudentsAmount = facultyStudents.Max();
            var biggestFaculty = await context.Faculties.Where(f => f.Students.Count == maxStudentsAmount).ToListAsync();
            Console.WriteLine("Faculties with the biggest amount of students:");
            biggestFaculty.ForEach(f => Console.WriteLine(f.Name));

            Console.ReadKey();
        }
    }
}
