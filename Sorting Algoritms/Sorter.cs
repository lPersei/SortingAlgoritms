using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{   
    /// <summary>
    /// Class for swapping elements in array
    /// </summary>
    public class Sorter
    {
        public static List<int> SortedItemsList = new List<int>();
        public void Swap(int IndexA, int IndexB)
        {
            var tmp = SortedItemsList[IndexA];
            SortedItemsList[IndexA] = SortedItemsList[IndexB];
            SortedItemsList[IndexB] = tmp;
        }
    }
}
