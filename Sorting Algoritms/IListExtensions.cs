using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Extension class for the IList
    /// </summary>
    static class IListExtensions
    {
        /// <summary>
        /// Swapping method of two elements in array based on their indexes. 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="SwappedArray">Extension for every IList object</param>
        /// <param name="IndexA">First index for swapping</param>
        /// <param name="IndexB">Second index for swapping</param>
        public static void Swap<T>(this IList<T> SwappedArray, int IndexA, int IndexB) where T : IComparable
        {
            var tmp = SwappedArray[IndexA];
            SwappedArray[IndexA] = SwappedArray[IndexB];
            SwappedArray[IndexB] = tmp;
        }
        /// <summary>
        /// Printing method of the array
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ItemList"></param>
        public static void PrintList<T>(this IList<T> ItemList)
        {
            foreach (T item in ItemList)
            {
                Console.Write(item.ToString() + " ");
            }
        }
    }
}
