using System;

namespace FirstTask.MathModule
{
    public static class Task1C
    {
        public static double Calculate(double e)
        {
            double i = 0;
            double sumC = 0;
            double sumInitial;
            while(true)
            {
                sumInitial = Math.Pow(-1, i) / Factorial(i);
                i++;
                if (Math.Abs(sumInitial) < e) break;
                sumC += sumInitial;
            }
            return sumC;
        }
        static double Factorial(double i)
        {
            if (i == 0)
            {
                return 1;
            }
            else
            {
                return i * Factorial(i - 1);
            }
        }
    }
}
