using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
