using FirstTask.MathModule;
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

            //zefirlover's Task1A
            Console.WriteLine("First task");

            Console.WriteLine("Enter a z variable");
            double z = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a k variable");
            double k = Convert.ToDouble(Console.ReadLine());

            if (z < 15)
            {
                double sumA = Task1A.Calculate(z, k);
                Console.WriteLine("sum = " + sumA);
            }
            else Console.WriteLine("Fuck you");
            //end

            //zefirlover's Task1B
            Console.WriteLine("Second task");

            Console.WriteLine("Enter a t variable");
            double t = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a n variable");
            double n = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a l variable");
            int l = Convert.ToInt32(Console.ReadLine());

            if (t > 0)
            {
                double sumB = Task1B.Calculate(t, n, l);
                Console.WriteLine("sum = " + sumB);
            }
            else Console.WriteLine("Fuck you");
            //end

            //zefirlover's Task1C
            Console.WriteLine("Third task");

            Console.WriteLine("Enter a e variable");
            double e = Convert.ToDouble(Console.ReadLine());

            double sumC = Task1C.Calculate(e);
            Console.WriteLine("sum = " + sumC);
            //end
        }
    }
}
