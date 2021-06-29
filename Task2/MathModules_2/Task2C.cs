using System;

namespace Task2.MathModules_2
{
    //2_61
    public static class Task2C
    {

        public static int[] getCArray(int[] array_a, int[] array_b)
        {
            //returns array c from task
            //if arr_a.lenght != arr_b.lenght throws ArgumetException
            if (array_a.Length != array_b.Length)
                throw new ArgumentException("");
            int[] array_c = new int[array_a.Length];
            for (int i = 0; i < array_a.Length; i++)
            {
                int tmp = 0;
                if (array_a[i] > 0 && array_b[i] > 0)
                    tmp = array_a[i] + array_b[i];
                else if (array_a[i] < 0 && array_b[i] < 0)
                    tmp = array_a[i] * array_b[i];
                array_c[i] = tmp;
            }

            return array_c;
        }
    }
}
