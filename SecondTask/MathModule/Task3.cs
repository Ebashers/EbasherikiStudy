using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.MathModule
{
    public static class Task3
    {
        public static int[] Calculate(int[] thirdArray)
        {
            //int[] fourthArray = thirdArray.ToArray();

            int maxValue = int.MinValue;
            foreach (int a in thirdArray)
            {
                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            for (int a = 0; a < thirdArray.Length; a++)
            {
                if (a == 0)
                {
                    a = 1;
                    Console.WriteLine(a);
                }
                else if (a < 0)
                {
                    a += maxValue;
                    Console.WriteLine(a);
                }
                else if (a > 0)
                {
                    a *= 2;
                    Console.WriteLine(a);
                }
            }
            int[] fourthArray = thirdArray.ToArray();
            foreach (int a in fourthArray)
            {
                Console.WriteLine(a);
            }
            return fourthArray;
        }
    }
}
