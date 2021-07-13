using University2.DB;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;

namespace University2
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new MyDbContext();
            await context.Database.MigrateAsync();
            var students = await context.Students.ToListAsync();
            students.ForEach(x => Console.WriteLine($"{x.Id} - {x.FirstName} - {x.LastName}"));
        }
    }
}
