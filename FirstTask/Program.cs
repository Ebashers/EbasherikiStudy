using FirstTask.MathModules;
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

            //Task1A
            Console.WriteLine("First task");

            Console.WriteLine("Enter a m variable");
            double m = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a k variable");
            double k = Convert.ToDouble(Console.ReadLine());

            if (k <= 30)
            {
                double sumA = Task1A.Calculate(m, k);
                Console.WriteLine("sum = " + sumA);
            }
            else Console.WriteLine("Ooops");
//end
        }
    }
}