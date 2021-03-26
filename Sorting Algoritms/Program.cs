using System;
using System.Collections.Generic;

namespace Sorting_Algoritms
{
    class Program
    {
        static void Main(string[] args)
        {
            Randomizer randomizer = new Randomizer();

            IList<int> ItemList = randomizer.FillWithValues(50, 0, 100);
            //IList<double> ItemList = new List<double> { 2.33, 1.3, 1.01, 1.09, 3.28, 100.92 };
            //IList<char> ItemList = new List<char> {'c','a','A','b' };

            HeapSort Sort = new HeapSort();
            ItemList = Sort.GetSortedArray(ItemList);
            
            PrintList(ItemList);
        }

        public static void PrintList<T>(IList<T> ItemList)
        {
            foreach (T item in ItemList)
            {
                Console.Write(item.ToString() + " ");
            }           
        }
    }
}
