namespace SecondTask
{
    public static class FirstTask
    {
        public static int CalcNegative(int[] list, int length)
        {
            int i;
            var count = 0;
            for (i = 0; i < length; i++)
            {
                if (list[i] < 0)  
                count++;  
            }  
            return count;  
        }
    }
}