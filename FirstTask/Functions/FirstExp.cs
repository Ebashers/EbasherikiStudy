using System;

namespace FirstTask.Functions
{
    public class FirstExp
    {
        public static double Calc(double k, double a, double b)
        {
            int i;
            double sum1 = 0;

            for (i = 1; i <= k; i++)
            {
                sum1 += Math.Sqrt(a * i * Math.Sqrt(b / i));
            }
                
            return sum1;
        }
    }
}