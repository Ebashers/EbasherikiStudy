using System;
using FirstTask.Functions;

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string id = "";
            while (id != "0")
            {
                Console.WriteLine("1 = First task\n2 = Second task\n3 = Third task\n0 = Exit");
                id = Console.ReadLine();
                switch (id)
                {
                    case "1":


                        Console.WriteLine("First expression");

                        Console.WriteLine("a >= 0");
                        Console.WriteLine("Enter a variable");
                        double a = Convert.ToDouble(Console.ReadLine());
                        

                        Console.WriteLine("b >= 0");
                        Console.WriteLine("Enter b variable");
                        double b = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("2 < k <= 25");
                        Console.WriteLine("Enter k variable");
                        double k = Convert.ToDouble(Console.ReadLine());

                        if (k <= 30 && a >= 0 && b >= 0)
                        {
                            double firstSum = FirstExp.Calc(a, b, k);
                            Console.WriteLine("sum = " + firstSum);
                        }
                        else Console.WriteLine("Not today");

                        break;

                    case "2":


                        Console.WriteLine("Second expression");

                        Console.WriteLine("l > 0");
                        Console.WriteLine("Enter l variable");
                        double l = Convert.ToDouble(Console.ReadLine());

                        if (l > 0)
                        {
                            Console.WriteLine("t > 0");
                        }

                        Console.WriteLine("Enter t variable");
                        double t = Convert.ToDouble(Console.ReadLine());

                        if (t > 0 & l > 0)
                        {
                            double secondSum = SecondExp.Calc(t, l);
                            Console.WriteLine("sum = " + secondSum);
                        }
                        else Console.WriteLine("Not today");

                        break;

                    case "3":
                        
                        Console.WriteLine("Third expression");
                        Console.WriteLine("Enter e variable");
                        double e = Convert.ToDouble(Console.ReadLine());
                        double thirdSum = ThirdExp.Calc(e);
                        Console.WriteLine("sum = " + thirdSum);
                        break;
                    
                    default: throw new AggregateException("Unaccepteble operation code");
                }
            }
        }
    }
}
