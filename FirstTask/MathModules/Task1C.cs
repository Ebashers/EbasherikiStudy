using System;

namespace FirstTask.MathModules
{
    public static class Task1C
    {
        public static double Calculate(double e)
        {
            double i = 1;
            double sum = 0;
            double sumInitial;
            while (true)
            {
                sumInitial = 1 / Math.Pow(i, 2);
                i++;
                if (Math.Abs(sumInitial) < e) break;
                sum += sumInitial;
            }

            return sum;
        }
    }
}
