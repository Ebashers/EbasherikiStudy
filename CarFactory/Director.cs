using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    class Director
    {
        public Car GetCar(CarBuilder carBuilder)
        {
            carBuilder.CreateCar();
            carBuilder.SetBody();
            carBuilder.SetEngine();
            carBuilder.SetOptions();
            carBuilder.SetSuspension();
            return carBuilder.Car;
        }
    }
}
