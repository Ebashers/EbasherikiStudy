namespace SecondTask.ListModule
{
    public class TaskB
    {
        public static double Calculate(int[] list)
        {
            int i;
            double sum = 0;
            for (i = 0; i < list.Length; i += 2)
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