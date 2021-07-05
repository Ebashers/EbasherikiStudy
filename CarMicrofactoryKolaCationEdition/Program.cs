using System;

namespace FluentCarFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Car suv = new CarBuilder().SetBody("SUV").SetEngine("V8").SetSuspension("standart").SetOptions("a toilet in the place of the passenger seat");
            Car houseOnWheels = Car.CreateCar().SetBody("big house body").SetSuspension("cargo shassis").SetOptions("without toilet");
            // сральнік спиздили(

            Console.WriteLine("Body: " + suv.Body);
            Console.WriteLine("Engine: " + suv.Engine);
            Console.WriteLine("Suspension: " + suv.Suspension);
            Console.WriteLine("Options: " + suv.Options);

            Console.WriteLine("=======================================");

            Console.WriteLine("Body: " + houseOnWheels.Body);
            Console.WriteLine("Suspension: " + houseOnWheels.Suspension);
            Console.WriteLine("Options: " + houseOnWheels.Options);
        }
    }
}
