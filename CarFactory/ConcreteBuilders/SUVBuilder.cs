using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarFactory.ConcreteBuilders
{
    class SUVBuilder : CarBuilder
    {
        public override void SetBody()
        {
            Car.Body = "SUV";
        }

        public override void SetEngine()
        {
            Car.Engine = "V8 5.0";
        }

        public override void SetOptions()
        {

        }

        public override void SetSuspension()
        {
            Car.Suspension = "Offroad";
        }
    }
}
