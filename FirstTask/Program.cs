using FirstTask.MathModule;
using System;


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

                        //Pavel's First Solution
                        Console.WriteLine("First solution");

                        Console.WriteLine("t < 0");
                        Console.WriteLine("Enter t variable");
                        double t = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("s >= 0");
                        Console.WriteLine("Enter s variable");
                        double s = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("2 < k <= 25");
                        Console.WriteLine("Enter k variable");
                        double k = Convert.ToDouble(Console.ReadLine());

                        if (k > 2 & k <= 25 & s >= 0 & t < 0)
                        {
                            double firstSum = FirstSolution.Calculate(t, s, k);
                            Console.WriteLine("sum = " + firstSum);
                        }
                        else Console.WriteLine("Nope");
                        break;
                        //end
                    case "2":

                        //Pavel's Second Solution
                        Console.WriteLine("Second solution");
                        
                        Console.WriteLine("i = 1 or i >= 2");
                        Console.WriteLine("Enter i variable");
                        double i = Convert.ToDouble(Console.ReadLine());

                        if (i == 1 | i == 2)
                        {
                            Console.WriteLine("t > 0");   
                        }
                        Console.WriteLine("Enter t variable");
                        t = Convert.ToDouble(Console.ReadLine());

                        if ((t > 0 & (i == 1 | i == 2)) | (i > 2))
                        {
                            double secondSum = SecondSolution.Calculate(t, i);
                            Console.WriteLine("sum = " + secondSum);
                        }
                        else Console.WriteLine("Nope");
                        break;
                        //end
                    case "3":

                        //Pavel's Third Solution
                        Console.WriteLine("Third solution");

                        Console.WriteLine("Enter e variable");
                        double e = Convert.ToDouble(Console.ReadLine());

                        double thirdSum = ThirdSolution.Calculate(e);
                        Console.WriteLine("sum = " + thirdSum);
                        break;
                    //end
                }
            }
        }
    }
}