using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Models
{
    class Smartphone : Telephone
    {
        public Smartphone(int year, bool fastCharger) : base(year)
        {
            FastCharger = fastCharger;
        }

        public bool FastCharger { get; set; }
        public override int Battery(int batteryCharge)
        {
            int i = 0;
            //bool fastCharger = true;
            if (batteryCharge >= 100)
            {
                FastCharger = false;
            }

            // overpower (101) exception
            if (FastCharger && batteryCharge == 99)
            {
                batteryCharge++;
                i++;
                return batteryCharge;
            }

            if (FastCharger && batteryCharge < 100)
            {
                batteryCharge += 2;
                i++;
                return batteryCharge;
            }
            else
            {
                return base.Battery(batteryCharge);
            }
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

            if (mobileConnection)
            {
                mobileInternet = true;
            }
            else mobileInternet = false;

            string result = $"{base.Communication(provider, weatherWariable, mobileConnection, call)}. Internet: {mobileInternet}";
            return result;
        }
    }
}
