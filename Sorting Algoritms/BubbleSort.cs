using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the bubble-sorting algorithm
    /// </summary>
    public class BubbleSort : ISorter
    {
        public IList<T> GetSortedArray<T>(IList<T> ArraySorted) where T : IComparable
        {
            bool swapped = true;
            int Size = ArraySorted.Count;
            //while elements was not swapped
            while (swapped == true)
            {
                swapped = false;
                for (int i = 0; i < Size - 1; ++i)
                {
                    if (ArraySorted[i].CompareTo(ArraySorted[i + 1]) > 0)
                    {
                        ArraySorted.Swap(i, i + 1);
                        swapped = true;
                    }
                }
            }
            return ArraySorted;
        }
    }
}
