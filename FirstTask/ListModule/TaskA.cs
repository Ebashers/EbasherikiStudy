namespace FirstTask.ListModule
{
    public static class TaskA
    {
        public static double Calculate(int[] list, int length)
        {
            int i;
            double sum = 0;
            for (i = 0; i < length; i++)
            {
                if (list[i] > 3)
                {
                    sum += list[i];   
                }
            }
            return sum;
        }
    }
}