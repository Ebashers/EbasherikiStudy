using System;

namespace FirstTask.Functions
{
    public class SecondExp
    {
        public static double Calc(double t, double l)
        {
            double sum2 = 0;
            for (int i = 1; i <= t; i++)
            {
                if (l % 2==1)
                {
                    sum2 += Math.Sqrt(t*l);
                }
                else
                {
                    sum2 += l/Math.Sqrt(t);
                }
            }
            
            
            return sum2;
        }
    }
}