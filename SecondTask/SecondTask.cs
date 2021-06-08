namespace SecondTask
{
    public static class SecondTask
    {
        public static int LargestElement(int[] list, int length )
        {
            int i;
            var max = list[0];
            for (i = 1; i < length; i++)
                if (list[i] > max)
                    max = list[i];
 
            return max;
        }
    }
}