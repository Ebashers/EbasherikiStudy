using System;
using FirstTask;

namespace SecondTask
{
    class Program
    {
        private static void Main(string[] args)
        {
            int k;
            Console.WriteLine("Enter list size"); 
            var listSize = Convert.ToInt32(Console.ReadLine());
            var rndmlist = GetList.GetRandomList(listSize); 
            Console.WriteLine("List:");
            
            for (var l = 0; l < listSize; l++)
            {
                Console.Write(rndmlist[l] + " ");
            }
            
            Console.WriteLine("");
            Console.WriteLine("Amount of elements that < 0 = " + FirstTask.CalcNegative(rndmlist));
            Console.WriteLine("Largest element in list = " + SecondTask.LargestElement(rndmlist));
            
            
            Console.WriteLine("New array according to third task = " );
            var newlist = ThirdTask.NewList(rndmlist, listSize);
            for (k = 0; k < listSize; k++)
            {
                Console.Write(newlist[k] + " " );
            }
        }
    }
}