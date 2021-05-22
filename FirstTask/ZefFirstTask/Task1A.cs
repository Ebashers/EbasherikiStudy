using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ZefFirstTask
{
    public static class Task1A
    {
        public static double Calculate(double z)
        {
            int i;
            double k;
            double sum = 0;
            for (k=0; k<15; k++)
            {
                for (i=1; i<=k; i++)
                {
                    sum += ((1 / Math.Sqrt(z * i)) + Math.Tan(k / i));
                }
            }
            return sum;
        }
    }
}
