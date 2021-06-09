using System;
using ThirdTask.Models;

namespace ThirdTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Smartphone smartphone = new Smartphone(2002);
            Telephone telephone = new Telephone(2001);
            int batteryCharge1 = telephone.Battery(100);
            int batteryCharge2 = smartphone.Battery(100);
            string mobileConnection1 = telephone.Communication("kyivstar", "sunny", false, false);

            Console.WriteLine("batteryCharge");
            Console.WriteLine(batteryCharge1);
            Console.WriteLine(batteryCharge2);

            Console.WriteLine("mobileConnection");
            Console.WriteLine(mobileConnection1);
            Console.ReadKey();
        }
    }
}
