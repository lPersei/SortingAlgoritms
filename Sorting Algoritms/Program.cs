using System;
using System.Collections.Generic;

namespace Sorting_Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();

            Sorter.SortedItemsList = randomizer.FillWithValues(100, 0, 200);

            SelectionSort selectionSort = new SelectionSort();
            selectionSort.sort();

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
