using System;

namespace SecondTask.ListModule
{
    public class TaskC
    {
        public static double[] Calculate(int[] list)
        {
            int i;
            double[] newList = new double[list.Length];
            double min = list[0];
            for (i = 1; i < list.Length; i++)
            {
                if (list[i] < min) min = list[i];
            }
            if (min == 0)
            {
                for (i = 0; i < list.Length; i++)
                {
                    newList[i] = -10;
                }
            }
            else
            {
                for (i = 0; i < list.Length; i++)
                {
                    newList[i] = Convert.ToDouble(list[i]);
                    newList[i] /= min;
                }
            }
            return newList;
        }
    }
}