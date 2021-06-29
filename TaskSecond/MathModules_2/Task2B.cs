namespace FirstTask.MathModules_2
{
    //Find sum min positive + sum number - 2_31
    
    public static class Task2B
    {
        public static int getMinNumSum(int[] arr)
        {
            //returns sum of min positive value of arr and index 
            //if array do not contains positive numbers, returns 0
            int min_ind = -1;
            int etalon = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0 && arr[i] < etalon)
                    min_ind = i;
            }
            int res = 0;
            if (min_ind != -1)
                res = min_ind * arr[min_ind];
            return res;
        }
    }
}