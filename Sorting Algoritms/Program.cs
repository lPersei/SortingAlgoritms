using System;
using System.Collections.Generic;

namespace Sorting_Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();
            List<int> Arr = new List<int> { 9, 4, 2, 1, 7, 5, 34, 3 };
            BubbleSort bubbleSort = new BubbleSort();
            bubbleSort.sort();
            foreach(int item in bubbleSort.SortedItemsList)
            {
                Console.Write(item.ToString() + " ");
            }
            Console.WriteLine(Environment.NewLine);

            sorter.SortedItemsList = randomizer.FillWithValues(100, 0, 200);
            bubbleSort = new BubbleSort<int>(sorter.SortedItemsList);
            bubbleSort.sort();
            foreach (int item in sorter.SortedItemsList)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
