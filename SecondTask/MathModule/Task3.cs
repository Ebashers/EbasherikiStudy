using System;
using System.Linq;

namespace SecondTask.MathModule
{
    public static class Task3
    {
        public static int[] Calculate(int[] thirdArray)
        {
            int[] fourthArray = new int[thirdArray.Length];
            int maxValue = thirdArray.Max();

            for (int i = 0; i < thirdArray.Length; i++)
            {
                //debug variable
                //var x = thirdArray[i];
                if (thirdArray[i] == 0)
                {
                    fourthArray[i] = 1;
                }
                else if (thirdArray[i] < 0)
                {
                    fourthArray[i] = thirdArray[i] + maxValue;
                }
                else if (thirdArray[i] > 0)
                {
                    fourthArray[i] = thirdArray[i] * 2;
                }
            }
            foreach (int a in fourthArray)
            {
                Console.WriteLine(a);
            }
            return fourthArray;
        }
    }
}
