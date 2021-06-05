﻿using SecondTask.ListModule;
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
            Console.WriteLine("Enter list size");
            listSize = Convert.ToInt32(Console.ReadLine());
            int[] rlist = new int[listSize];
            rlist = RandomList.GetRandom(listSize);
            Console.WriteLine("List:");
            for (int l = 0; l < listSize; l++)
            {
                Console.Write(rlist[l] + " ");
            }

            Console.WriteLine("");
            Console.WriteLine("Sum of elements which are more than 3 = " + TaskA.Calculate(rlist, listSize));
            //Second part
            Console.WriteLine("List with positions");
            for (int l = 0; l < listSize; l++)
            {
                Console.WriteLine("i[{0}] = {1} ", l, rlist[l]);
            }

            Console.WriteLine("Sum of even elements of the array, standing in odd places = "
                              + TaskB.Calculate(rlist, listSize));
            //Third part
            Console.WriteLine("New list:");
            double[] newList = TaskC.Calculate(rlist, listSize);
            for (int l = 0; l < listSize; l++)
            {
                Console.Write(newList[l] + " ");
            }

            Console.WriteLine("");
            //end
        }
    }
}