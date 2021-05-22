using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ZefFirstTask
{
    public static class Task1C
    {
        public static double Calculate(double e)
        {
            double i = 0;
            double SumC = 0;
            double SumT;
            while(true)
            {
                SumT = Math.Pow(-1, i) / Factorial(i);
                i++;
                if (Math.Abs(SumT) < e) break;
                SumC += SumT;
            }
            return SumC;
        }
        static double Factorial(double i)
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
