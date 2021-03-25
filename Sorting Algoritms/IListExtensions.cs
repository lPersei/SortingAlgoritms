using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    static class IListExtensions
    {
        public static void Swap<T>(this IList<T> SwappedArray, int IndexA, int IndexB) where T : IComparable
        {
            var tmp = SwappedArray[IndexA];
            SwappedArray[IndexA] = SwappedArray[IndexB];
            SwappedArray[IndexB] = tmp;
        }
    }
}
