using FirstTask.MathModules_1;
using FirstTask.MathModules_2;
using System;


namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //code to use "args"
            if (args is null)
            {
                throw new ArgumentNullException(nameof(args));
            }

            //Task1 - Variant1 
            Console.WriteLine("First task");

            Console.WriteLine("Enter m variable");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter k variable");
            double k = Convert.ToDouble(Console.ReadLine());

            if (k <= 30)
            {
                double sumA = Task1A.Calculate(m, k);
                Console.WriteLine("sum = " + sumA);
            }
            else Console.WriteLine("Wrong k value");
            //end
            
            //Task1B - Variant6
            Console.WriteLine("Second task");

            Console.WriteLine("Enter t variable");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter i variable");
            int i = Convert.ToInt32(Console.ReadLine());

            if (t > 0)
            {
                double res = Task1B.Calculate(t, i);
                Console.WriteLine("sum = " + res);
            }
            else Console.WriteLine("t has negative value");
            //end


            //Task1C - Variant11
            Console.WriteLine("Third task");

            Console.WriteLine("Enter E variable");
            double e = Convert.ToDouble(Console.ReadLine());

            double sum = Task1C.Calculate(e);
            Console.WriteLine("sum = " + sum);
            //end
        }
    }
}