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
            string callVar = telephone.Call("1");
            string callVar2 = smartphone.Call("1");
            
            Console.WriteLine(callVar);
            Console.WriteLine(callVar2);
            Console.ReadKey();
        }
    }
}
