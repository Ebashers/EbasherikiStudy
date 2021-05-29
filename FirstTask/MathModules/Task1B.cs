using System;

namespace FirstTask.MathModules
{
    public static class Task1B
    {
        public static double Calculate(double t, double i)
        {
            double res = 0;
            for (int k = 1; k <= i; k++)
            {
                //Сonsider the 3 conditions of the task
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
                        res += k * t;
                    }
                }
                
            }
            return res;
        }
    }
}