using System;

namespace SecondTask.ListModule
{
    public class TaskC
    {
        public static double[] Calculate(int[] list, int length)
        {
            int i;
            double[] newList = new double[length];
            double min = list[0];
            for (i = 1; i < length; i++)
            {
                if (list[i] < min) min = list[i];
            }
            if (min == 0)
            {
                for (i = 0; i < length; i++)
                {
                    newList[i] = -10;
                }
            }
            else
            {
                for (i = 0; i < length; i++)
                {
                    newList[i] = Convert.ToDouble(list[i]);
                    newList[i] /= min;
                }
            }
            return newList;
        }
    }
}