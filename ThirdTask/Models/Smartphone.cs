using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Models
{
    class Smartphone : Telephone
    {
        public Smartphone(int year) : base(year)
        {
        }

        public override int Battery(int batteryCharge)
        {
            int i = 0;
            bool fastCharger = true;
            if (fastCharger)
            {
                batteryCharge += 2;
                i++;
            }
            else
            {
                base.Battery(batteryCharge);
            }
            return base.Battery(batteryCharge);
            return batteryCharge;
        }

        public override string Communication(string provider, string weatherWariable, bool mobileConnection, bool call)
        {
            base.Communication(provider, weatherWariable, mobileConnection, call);
            bool mobileInternet;

            // kolkhoz moment
            string[] weather = new string[] { "sunny", "cloudy", "rainy", "stormy" };
            if (weatherWariable == weather[3])
            {
                mobileConnection = false;
            }
            else mobileConnection = true;

            if (mobileConnection = true)
            {
                mobileInternet = true;
            }
            else mobileInternet = false;

            return base.Communication(provider, weatherWariable, mobileConnection, call);
            return mobileInternet.ToString();
        }
    }
}
