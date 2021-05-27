using System;

namespace FirstTask.MathModule
{
    public static class ThirdSolution
    {
        public static double Calculate(double e)
        {
            double i = 1;
            double sumThird = 0;
            double sumCurrent;
            while(true)
            {
                sumCurrent = 1 / (i*(i+1));
                i++;
                if (Math.Abs(sumCurrent) < e) break;
                sumThird += sumCurrent;
            }
            return sumThird;
        }
    }
}