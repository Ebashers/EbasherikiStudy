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
            
            Console.WriteLine(batteryCharge1);
            Console.ReadKey();
        }
    }
}
