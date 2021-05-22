using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstTask.ZefFirstTask
{
    public static class Test
    {
        public static double Calculate(double TestZ, double TestK)
        {
            int i = 0;
            double TestSum = 0;
            if (TestZ < 15)
            {
                for (i = 1; i <= TestK; i++)
                {
                    TestSum += ((1 / Math.Sqrt(TestZ * i)) + Math.Tan(TestK / i));
                }
                return TestSum;
            }
            else
            {
                Console.WriteLine("Fuck you");
                return 0;
            }
        }
    }
}
