using System;

namespace SecondTask
{
    public static class GetList
    {
        public static int[] GetRandomList(int x)
        {
            var genrList = new Random();
            int i;
            int[] randomList = new int[x];
            for (i = 0; i < x; i++)
            {
                randomList[i] = genrList.Next(-7, 9);
                
            }

            return randomList;
        }
    }
}