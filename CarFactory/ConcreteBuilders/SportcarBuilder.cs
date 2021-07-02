using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.ConcreteBuilders
{
    class SportcarBuilder : CarBuilder
    {
        public override void SetBody()
        {
            Car.Body = "Coupe";
        }

        public override void SetEngine()
        {
            Car.Engine = "i5 quattro";
        }

        public override void SetOptions()
        {
            Car.Options = "Rally frame";
        }

        public override void SetSuspension()
        {
            Car.Suspension = "Rally";
        }
    }
}
