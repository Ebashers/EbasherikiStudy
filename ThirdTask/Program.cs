using System;
using ThirdTask.Models;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone(2002, false);
            Telephone telephone = new Telephone(2001);
            int batteryCharge1 = telephone.Battery(100);
            int batteryCharge2 = smartphone.Battery(40);
            string mobileConnection1 = telephone.Communication("kyivstar", "stormy", false, false);
            string mobileConnection2 = smartphone.Communication("kyivstar", "stormy", false, false);

            Console.WriteLine("Battery Charge");
            Console.WriteLine(batteryCharge1);
            Console.WriteLine(batteryCharge2);
            Console.WriteLine(" ");

            Console.WriteLine("Mobile Connection (telephone)");
            Console.WriteLine(mobileConnection1);
            Console.WriteLine(" ");

            Console.WriteLine("Mobile Connection (smartphone)");
            Console.WriteLine(mobileConnection2);

            Console.ReadKey();
        }
    }
}
