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
            bool fastCharger;
            if (fastCharger = true)
            {
                batteryCharge = batteryCharge + 2;
                i++;
            }
            else
            {
                base.Battery(batteryCharge);
            }
            return base.Battery(batteryCharge);
            return batteryCharge;
        }

        public override string Communication()
        {
            base.Communication();
            bool mobileInternet;
            bool mobileConnection = true;
            if (mobileConnection = true)
            {
                mobileInternet = true;
            }
            return base.Communication();
            return mobileInternet.ToString();
        }
    }
}
