using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ZefFirstTask
{
    public static class Task1A
    {
        public static double Calculate(double z, double k)
        {
            int i;
            double SumA = 0;
            if (z < 15)
            {
                for (i = 1; i <= k; i++)
                {
                    SumA += ((1 / Math.Sqrt(z * i)) + Math.Tan(k / i));
                }
                return SumA;
            }
            else
            {
                Console.WriteLine("Fuck you");
                return 0;
            }
        }
    }
}
