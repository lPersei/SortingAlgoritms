﻿using System;
using System.Collections.Generic;

namespace Sorting_Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();

            Sorter.SortedItemsList = randomizer.FillWithValues(50, 0, 100);

            CountingSort Sort = new CountingSort();
            Sort.sort();

            PrintList();
        }

        public static void PrintList()
        {
            foreach (int item in Sorter.SortedItemsList)
            {
                Console.Write(item.ToString() + " ");
            }           
        }
    }
}
