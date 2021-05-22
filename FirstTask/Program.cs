using System;
using FirstTask.ZefFirstTask;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test1
            Console.WriteLine("Test");

            Console.WriteLine("Enter a z variable");
            double TestZ = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a k variable");
            double TestK = Convert.ToDouble(Console.ReadLine());

            double TestSum = Test.Calculate(TestZ, TestK);
            Console.WriteLine("sum = " + TestSum);
            //end

            //zefirlover's Task1A
            Console.WriteLine("First task");

            Console.WriteLine("Enter a z variable");
            double z = Convert.ToDouble(Console.ReadLine());

            double sum = Task1A.Calculate(z);
            Console.WriteLine("sum = " + sum);
            //end

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
            //end

            //zefirlover's Task1C
            Console.WriteLine("Third task");

            Console.WriteLine("Enter a e variable");
            double e = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a k variable");
            double StartK = Convert.ToDouble(Console.ReadLine());

            double SumC = Task1C.Calculate(e, StartK);
            Console.WriteLine("sum = " + SumC);
            //end
        }
    }
}
