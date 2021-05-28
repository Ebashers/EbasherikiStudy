using SecondTask.MathModule;
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

            //Task 1
            Console.WriteLine("First task");

            Console.WriteLine("Enter values to array");
            int[] firstArray = new int[5];
            Console.WriteLine("Enter first value");
            firstArray[0] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second value");
            firstArray[1] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third value");
            firstArray[2] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter fourth value");
            firstArray[3] = Convert.ToInt32(Console.ReadLine());

            int maxValue = Task1.Calculate(firstArray);
            Console.WriteLine("Max Value = " + maxValue);
            //end


        }
    }
}
