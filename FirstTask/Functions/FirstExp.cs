using System;

namespace FirstTask.Functions
{
    public class FirstExp
    {
        public static double Calc(double k, double a, double b)
        {
            
            double sum1 = 0;

            for (var i = 1; i <= k; i++)
            {
                sum1 += Math.Sqrt(a * i * Math.Sqrt(b / i));
            }
                
            return sum1;
        }
    }
}