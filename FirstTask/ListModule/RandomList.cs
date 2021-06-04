using System;

namespace FirstTask.ListModule
{
    public static class RandomList
    {
        public static int[] GetRandom(int n)
        {
            var rand = new Random();
            int i;
            int[] randomList = new int[n];
            for (i = 0; i < n; i++)
            {
                randomList[i] = rand.Next(0,10);
            }
            
            return randomList;
        }
    }
}