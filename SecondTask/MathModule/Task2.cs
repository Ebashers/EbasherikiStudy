using System.Linq;

namespace SecondTask.MathModule
{
    public static class Task2
    {
        public static int Calculate(int[] secondArray)
        {
            int maxValue = secondArray.Max();
            int sum = maxValue + secondArray[1];
            return sum;
        }
    }
}
