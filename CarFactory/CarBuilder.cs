using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory
{
    abstract class CarBuilder
    {
        public Car Car { get; protected set; }
        public void CreateCar()
        {
            Car = new Car();
        }
        public abstract void SetEngine();
        public abstract void SetSuspension();
        public abstract void SetBody();
        public abstract void SetOptions();
    }
}
