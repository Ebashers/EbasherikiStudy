using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ZefFirstTask
{
    public static class Task1C
    {
        public static double Calculate(double e, double StartK)
        {
            int i;
            double k;
            double SumC = 0;
            for (k = StartK; k > 0; k++)
            {
                for (i = 1; i <= k; i++)
                {
                    SumC = Math.Pow(-1, i) / Factorial(i);
                    if (Math.Abs(SumC) < e) break;
                }
            }
            return SumC;
        }
        static int Factorial(int i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }
    }
}
