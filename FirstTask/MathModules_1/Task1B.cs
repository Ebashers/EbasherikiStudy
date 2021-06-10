using System;

namespace FirstTask.MathModules_1
{
    public static class Task1B
    {
        public static double Calculate(double t, double i)
        {
            double res = 0;
            if (i == 1)
            {
                res += Math.Sqrt(t);
            }
            else
            {
                if (i == 2)
                {
                    res += 1 / Math.Sqrt(t);
                }
                else
                {
                    for (int k = 1; k <= i; k++)
                    {
                        res += k * t;
                    }
                }
            }
            return res;
        }
    }
}