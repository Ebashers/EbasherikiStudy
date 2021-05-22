using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ZefFirstTask
{
    public static class Task1B
    {
        public static double Calculate(double t, double n, int l)
        {
            double SumB = 0;
            for (int i = 1; i <= n; i++)
            {
                if (l % 2 == 0)
                {
                    SumB += ((1 / Math.Sqrt(t)) * l);
                }
                else
                {
                    SumB += ((1 / t) * l);
                }
            }
            return SumB;
        }
    }
}
