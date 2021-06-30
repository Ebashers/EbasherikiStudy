using System;

namespace SecondTask
{
    public static class SecondTask
    {
        public static int LargestElement(int[] list)
        {
            int i;
            var max = list[0];
            for (i = 1; i < list.Length; i++)
                if (Math.Abs(list[i]) > Math.Abs(max))
                    max = list[i];
 
            return max;
        }
    }
}