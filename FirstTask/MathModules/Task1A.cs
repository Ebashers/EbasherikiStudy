using System;

namespace FirstTask.MathModules
{
    public static class Task1A
    {
        public static double Calculate(double m, double k)
        {
            int i;
            double sumA = 0;
            for (i = 1; i <= k; i++)
            {
                sumA += ((Math.Sqrt(m * 1 / i)) * Math.Sin(m * i));
            }
            return sumA;
        }
    }
}