namespace FirstTask.ListModule
{
    public class TaskB
    {
        public static double Calculate(int[] list, int length)
        {
            int i;
            double sum = 0;
            for (i = 1; i < length; i += 2)
            {
                if (list[i] % 2 == 0)
                {
                    sum += list[i];   
                }
            }
            return sum;
        }
    }
}