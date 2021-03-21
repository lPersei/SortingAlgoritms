using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the insertion-sorting algorithm
    /// </summary>
    class InsertionSort
    {
        public IList<T> GetSortedArray<T>(IList<T> ArraySorted) where T : IComparable
        {
            int Size = ArraySorted.Count;
            for (int i = 0; i < Size-1; ++i)
            {
                for (int j = i+1; j > 0; --j)
                {
                    if (ArraySorted[j-1].CompareTo(ArraySorted[j]) > 0)
                    {
                        ArraySorted.Swap(j-1, j);
                    }
                }
            }
            return ArraySorted;
        }
    }
}
