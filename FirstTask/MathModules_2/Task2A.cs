namespace FirstTask.MathModules_2
{
    //Find the number of positive elements - 2_1
    
    public static class Task1
    {
        public static int Calculate(int[] firstArray)
        {
            int maxValue = int.MinValue;
            foreach (int a in firstArray)
            {
                if (a > maxValue)
                {
                    maxValue = a;
                }
            }
            return maxValue;
        }
    }
}