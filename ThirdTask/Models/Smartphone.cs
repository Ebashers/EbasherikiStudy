
namespace ThirdTask.Models
{
    class Smartphone : Telephone
    {
        public bool MobileInternet { get; private set; }
        public bool FastCharger { get; set; }
        public Smartphone(int year, bool fastCharger, bool mobileConnection, bool call, bool mobileInternet) : base(year, mobileConnection, call)
        {
            FastCharger = fastCharger;
            MobileConnection = mobileConnection;
            MobileInternet = mobileInternet;
        }
        public override int Battery(int batteryCharge)
        {
            int i = 0;
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

        public override string Communication(string provider, string weatherWariable)
        {
            base.Communication(provider, weatherWariable);

            // kolkhoz moment
            string[] weather = new string[] { "sunny", "cloudy", "rainy", "stormy" };
            if (weatherWariable == weather[3])
            {
                MobileConnection = false;
            }
            else MobileConnection = true;

            if (MobileConnection)
            {
                MobileInternet = true;
            }
            else MobileInternet = false;

            string result = $"{base.Communication(provider, weatherWariable)}. Internet: {MobileInternet}";
            return result;
        }
    }
}
