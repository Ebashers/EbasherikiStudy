using System;

namespace FirstTask.MathModule
{
    public static class FirstSolution
    {
        public static double Calculate(double t, double s,double k)
        {
            int i;
            double sum1 = 0;
            for (i = 1; i <= k; i++)
            {
                sum1 += Math.Log(-t*i)*Math.Cos(Math.Sqrt(s*(1/Math.Pow(i, 2))));
            }
            return sum1;
        }
    }
}