using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the insertion-sorting algorithm
    /// </summary>
    class InsertionSort : Sorter
    {
        public void sort()
        {
            int Size = SortedItemsList.Count;
            for (int i = 0; i < Size-1; ++i)
            {
                for (int j = i+1; j > 0; --j)
                {
                    if (SortedItemsList[j-1] > SortedItemsList[j])
                    {
                        Swap(j-1, j);
                    }
                }
            }
        }
    }
}
