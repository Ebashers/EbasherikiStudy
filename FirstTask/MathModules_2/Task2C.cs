
using System;

namespace FirstTask.MathModules_2
{
    //2_61
    public static class Task2C
    {
        public static int[] getCArray(int[] arr_a, int[] arr_b){
            //returns array c from task
            //if arr_a.lenght != arr_b.lenght throws ArgumetException
            if(arr_a.Length != arr_b.Length)
                throw new ArgumentException("");
            int[] arr_c = new int[arr_a.Length];
            for(int i = 0; i < arr_a.Length; i++){
                int tmp = 0;
                if(arr_a[i] > 0 && arr_b[i] > 0)
                    tmp = arr_a[i] + arr_b[i];
                else if(arr_a[i] < 0 && arr_b[i] < 0)
                    tmp = arr_a[i] * arr_b[i];
                arr_c[i] = tmp;
            }
            return arr_c;
        }

    }
}