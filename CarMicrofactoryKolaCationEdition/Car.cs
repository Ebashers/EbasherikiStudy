
namespace FluentCarFactory
{
    public class Car
    {
        public string Engine { get; set; }
        public string Body { get; set; }
        public string Options { get; set; }
        public string Suspension { get; set; }

        public static CarBuilder CreateCar()
        {
            return new CarBuilder();
        }
    }
}
