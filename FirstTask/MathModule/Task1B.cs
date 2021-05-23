using System;

namespace FirstTask.MathModule
{
    public static class Task1B
    {
        public static double Calculate(double t, double n, int l)
        {
            double sumB = 0;
            for (int i = 1; i <= n; i++)
            {
                //if l isn't multiple of 2
                if (l % 2 == 0)
                {
                    sumB += ((1 / Math.Sqrt(t)) * l);
                }
                else
                {
                    sumB += ((1 / t) * l);
                }
            }
            return sumB;
        }
    }
}
