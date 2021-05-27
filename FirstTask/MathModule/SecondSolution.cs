using System;

namespace FirstTask.MathModule
{
    public static class SecondSolution
    {
        public static double Calculate(double t, double i)
        {
            double sumSecond = 0;
            if (i <= 2)
            {
                sumSecond = Math.Log(t);
            }
            else
            {
                for (int k = 1; k <= i; k++)
                {
                    sumSecond += (Math.Sin(t) / k);
                }
            }
            return sumSecond;
        }
    }
}