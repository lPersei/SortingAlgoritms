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
        public IList<T> GetSortedArray<T>(IList<T> ArraySorted) where T : IComparable;        
    }
}
