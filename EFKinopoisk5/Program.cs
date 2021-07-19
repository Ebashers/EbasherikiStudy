using EFKinopoisk5.DB;
using EFKinopoisk5.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace EFKinopoisk5
{
    class Program
    {
        static async Task Main(string[] args)
        {
            await using var context = new MyDbContext();
            await context.Database.EnsureDeletedAsync();
            await context.Database.MigrateAsync();
            //var actors = await context.Actors.ToListAsync();
            //var films = await context.Films.ToListAsync();

            var actor1 = new Actor { Name = "Biba" };
            var actor2 = new Actor { Name = "Boba" };
            var actor3 = new Actor { Name = "Ebanko" };
            var actor4 = new Actor { Name = "KolaCation" };

            var film1 = new Film { Name = "Dva dolboyoba" };
            var film2 = new Film { Name = "Ya ebu sobak" };
            var film3 = new Film { Name = "Super crossover" };

            actor1.Films.Add(film1);
            actor1.Films.Add(film3);

            actor2.Films.Add(film1);
            actor2.Films.Add(film3);

            actor3.Films.Add(film2);
            actor3.Films.Add(film3);

            context.Actors.Add(actor1);
            context.Actors.Add(actor2);
            context.Actors.Add(actor3);
            context.Actors.Add(actor4);

            context.SaveChanges();

            await using var context2 = new MyDbContext();
            var actors = await context2.Actors.Include(f => f.Films).ToListAsync();
            var films = await context2.Films.ToListAsync();

            Console.WriteLine("Actor without film");
            foreach (var a in actors)
            {
                if (a.Films.Count == 0)
                {
                    Console.WriteLine(a.Name);
                }
            }
            Console.WriteLine();

            Console.WriteLine("Enter the name of the actor");
            var firstActor = Convert.ToString(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("All actor's films and another films' actors");
            var selectedFilms = actors.Where(c => c.Name.ToLower() == firstActor.ToLower()).Select(f => f.Films).ToList();
            selectedFilms.ForEach(sf => Console.WriteLine(sf));
        }
    }
}
