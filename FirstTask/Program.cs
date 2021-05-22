using System;
using FirstTask.ZefFirstTask;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //zefirlover's Task1A
            Console.WriteLine("Enter a z variable");
            double z = Convert.ToDouble(Console.ReadLine());
            double sum = Task1A.Calculate(z);
            Console.WriteLine("sum = " + sum);
            //zefirlover's Task1A end


        }
    }
}
