using System;
using FirstTask.ZefFirstTask;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //zefirlover's Task1A
            Console.WriteLine("First task");

            Console.WriteLine("Enter a z variable");
            double z = Convert.ToDouble(Console.ReadLine());

            double sum = Task1A.Calculate(z);
            Console.WriteLine("sum = " + sum);
            //zefirlover's Task1A end

            //zefirlover's Task1B
            Console.WriteLine("Second task");

            Console.WriteLine("Enter a t variable");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a n variable");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a l variable");
            int l = Convert.ToInt32(Console.ReadLine());

            double SumB = Task1B.Calculate(t, n, l);
            Console.WriteLine("sum = " + SumB);
            //zefirlover's Task1B end

        }
    }
}
