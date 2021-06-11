using SecondTask.ListModule;
using System;

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            //Pavel's Arrays Solution
            //First part
            int listSize;
            while (true)
            {
                Console.WriteLine("Enter list size, or 0 to exit");
                listSize = Convert.ToInt32(Console.ReadLine());
                if (listSize == 0) break; 
                int[] rlist;
                rlist = RandomList.GetRandom(listSize);
                Console.WriteLine("List:");
                for (int l = 0; l < listSize; l++)
                {
                    Console.Write(rlist[l] + " ");
                }

                Console.WriteLine("");
                Console.WriteLine("Sum of elements which are more than 3 = " + TaskA.Calculate(rlist));
                //Second part
                Console.WriteLine("List with positions");
                for (int l = 0; l < listSize; l++)
                {
                    Console.WriteLine("i[{0}] = {1} ", l, rlist[l]);
                }

                Console.WriteLine("Sum of even elements of the array, standing in odd places = "
                                  + TaskB.Calculate(rlist));
                //Third part
                Console.WriteLine("New list:");
                double[] newList = TaskC.Calculate(rlist);
                for (int l = 0; l < listSize; l++)
                {
                    Console.Write(newList[l] + " ");
                }

                Console.WriteLine("");
                //end
            }
        }
    }
}