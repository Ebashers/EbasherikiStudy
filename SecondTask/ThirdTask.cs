using System;

namespace FirstTask
{
    public static class ThirdTask
    {
        public static int[] NewList(int[] list, int lenght)
        {
            int i;
            var newList = new int[lenght];
            for (i = 0; i < lenght; i++)
            {
                if (list[i] < 0)
                {
                    newList[i] =  list[i] * -1;
                }

                if (list[i] > 0)
                {
                    newList[i] = list[i] - 3;
                }

                if (list[i] == 0)
                {
                    newList[i] = list[i] = -2;
                }
            }
            return newList;
        } 
    }
}