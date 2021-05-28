using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.MathModule
{
    public static class Task2
    {
        public static int Calculate(int[] secondArray)
        {
            int maxValue = int.MinValue;
            foreach (int a in secondArray)
            {
                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            int sum = maxValue + secondArray[1];
            return sum;
        }
    }
}
