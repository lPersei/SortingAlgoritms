using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{   
    /// <summary>
    /// Class for swapping elements in array
    /// </summary>
    public interface ISorter
    {
        /// <summary>
        /// Drive method of sorting classes
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="ArraySorted">Array which needs to be sorted</param>
        /// <returns>Sorted Array</returns>
        public IList<T> GetSortedArray<T>(IList<T> ArraySorted) where T : IComparable;        
    }
}
