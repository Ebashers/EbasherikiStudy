namespace FirstTask.MathModules_2
{
    //Find the number of positive elements - 2_1
    
    public static class Task2A
    {
        public static int numberofPositive(int[] firstArray)
        {
            //returns number of positive elements in arr 
            int res = 0;
            foreach (int value in firstArray){
                if(value > 0)
                    res++;
            }
            return res;
        }
    }
}