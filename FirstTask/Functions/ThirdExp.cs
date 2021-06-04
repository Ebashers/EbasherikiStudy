using System;

namespace FirstTask.Functions
{
    public class ThirdExp
    {
        public static int factorial(int i)
        {
            if (i <= 0 )
            {
                return 1;
            }
            else
            {
                return i * factorial(i - 1);
            }
        }
        public static double Calc(double e)
        {
            int i = 0;
            double sum3 = 0;
            double sumCurrent;
            
            while (true)
            {
                sumCurrent = Math.Pow(-2, i) / factorial(i)* (i + 1);
                i++;
                
                if (Math.Abs(sumCurrent) < e) break;
                sum3 += sumCurrent;
            }
            
            return sum3;
        }
    }
}