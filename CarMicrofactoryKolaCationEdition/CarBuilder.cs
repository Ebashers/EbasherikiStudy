using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentCarFactory
{
    public class CarBuilder
    {
        private Car car;
        public CarBuilder()
        {
            car = new Car();
        }
        public CarBuilder SetEngine(string engine)
        {
            car.Engine = engine;
            return this;
        }
        public CarBuilder SetBody(string body)
        {
            car.Body = body;
            return this;
        }
        public CarBuilder SetSuspension(string suspension)
        {
            car.Suspension = suspension;
            return this;
        }
        public CarBuilder SetOptions(string options)
        {
            car.Options = options;
            return this;
        }

        public static implicit operator Car(CarBuilder builder)
        {
            return builder.car;
        }

        // аналог, шоб юзать Build()

        //public Car Build()
        //{
        //    return car;
        //}
    }
}
