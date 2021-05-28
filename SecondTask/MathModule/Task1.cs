using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondTask.MathModule
{
    public static class Task1
    {
        public static int Calculate(int[] firstArray)
        {
            int maxValue = int.MinValue;
            foreach (int a in firstArray)
            {
                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            return maxValue;
        }
    }
}
