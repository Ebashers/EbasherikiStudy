
namespace ThirdTask.Models
{
    class Telephone
    {
        public int Year { get; private set; }
        public bool MobileConnection { get; set; }
        public bool Call { get; set; }
        public Telephone(int year, bool mobileConnection, bool call)
        {
            Year = year;
            MobileConnection = mobileConnection;
            Call = call;
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
        public virtual string Communication(string provider, string connectionWariable)
        {
            string[] connections = new string[] { "the best", "great", "good", "bad" };
            if (connectionWariable == connections[3])
            {
                MobileConnection = false;
            }
            else MobileConnection = true;

            if (MobileConnection)
            {
                Call = true;
            }
            else Call = false;

            string result = $"Provider: {provider}. MobileConnection: {MobileConnection}. Call: {Call}";
            return result;
        }
    }
}
