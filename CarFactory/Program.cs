using CarFactory.ConcreteBuilders;
using System;

namespace CarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Director director = new Director();
            CarBuilder builder = new SUVBuilder();

            Car suv = director.GetCar(builder);
            Console.WriteLine("Body: " + suv.Body);
            Console.WriteLine("Engine: " + suv.Engine);
            Console.WriteLine("Suspension: " + suv.Suspension);
            Console.WriteLine("Options: " + suv.Options);

            Console.WriteLine("=======================================");

            builder = new SportcarBuilder();
            Car sportscar = director.GetCar(builder);
            Console.WriteLine("Body: " + sportscar.Body);
            Console.WriteLine("Engine: " + sportscar.Engine);
            Console.WriteLine("Suspension: " + sportscar.Suspension);
            Console.WriteLine("Options: " + sportscar.Options);
            Console.ReadKey();
        }
    }
}
