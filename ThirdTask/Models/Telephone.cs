using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdTask.Models
{
    class Telephone
    {
        //string callVar = "i will give you nightcall"
        // блять нахуй сука піздєц я не понімаю як з цією хуйнею работать, нахуя тут ктор, нада тут ктор, шо, куда блять, єбаний рот
        public Telephone(int year)
        {
            Year = year;
        }
        public int Year { get; private set; }
        public virtual int Battery(int batteryCharge)
        {
            int i = 0;
            bool charger = false;
            if (batteryCharge >= 100)
            {
                charger = false;
            }
            if (!charger)
            {
                batteryCharge--;
                i++;
            }
            else
            {
                batteryCharge++;
                i++;
            }
            return batteryCharge;
        }
        public virtual string Communication(string provider, string weatherWariable)
        {
            bool mobileConnection;
            bool call;
            string[] weather = new string[] { "sunny", "cloudy", "rainy", "stormy" };
            if (weatherWariable == weather[4])
            {
                mobileConnection = false;
            }
            else mobileConnection = true;
            if (mobileConnection)
            {
                call = true;
            }
            else call = false;
            return provider;
            return mobileConnection.ToString();
            return call.ToString();
        }
    }
}
