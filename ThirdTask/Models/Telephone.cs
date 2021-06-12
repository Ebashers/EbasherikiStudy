
namespace ThirdTask.Models
{
    class Telephone
    {
        public int Year { get; private set; }
        public Telephone(int year)
        {
            Year = year;
        }
        public virtual int Battery(int batteryCharge)
        {
            int i = 0;
            bool charger = true;
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
        public virtual string Communication(string provider, string weatherWariable, bool mobileConnection, bool call)
        {
            string[] weather = new string[] { "sunny", "cloudy", "rainy", "stormy" };
            if (weatherWariable == weather[3])
            {
                mobileConnection = false;
            }
            else mobileConnection = true;

            if (mobileConnection)
            {
                call = true;
            }
            else call = false;

            string result = $"Provider: {provider}. MobileConnection: {mobileConnection}. Call: {call}";
            return result;
        }
    }
}
