using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{   
    /// <summary>
    /// Class for swapping elements in array
    /// </summary>
    public static class Sorter
    {
        public static void Swap<T>(this IList<T> SwappedArray, int IndexA, int IndexB) where T : IComparable
        {
            var tmp = SwappedArray[IndexA];
            SwappedArray[IndexA] = SwappedArray[IndexB];
            SwappedArray[IndexB] = tmp;
        }
    }
}
