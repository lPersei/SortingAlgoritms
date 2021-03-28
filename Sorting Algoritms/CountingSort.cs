using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Class that implements count sorting algorithm
    /// </summary>
    class CountingSort
    {   
        /// <summary>
        /// Drive method of sorting. Usable only with integers because of algorithm`s logic.
        /// </summary>
        public IList<int> GetSortedArray(IList<int> ArraySorted)
        {
            int Size = ArraySorted.Count;
            int Max = ArraySorted.Max();
            int[] indexList = new int[Max+1];//Max+1 because of Zero value
            //Counts the number of occurances for each value
            for (int i = 0; i < ArraySorted.Count; ++i)
            {
                indexList[ArraySorted[i]]++;
            }
            //builds the array of order out of array with counted occurances
            for (int i = 0; i < indexList.Length - 1; ++i)
            {
                indexList[i + 1] = indexList[i] + indexList[i + 1];//next element = sum of two previous
            }
            //Array for sorted values
            IList<int> final = new List<int>();
            foreach(int x in ArraySorted)
            {
                final.Add(x);
            }
            
            /*
             * Get the *value* in the Unsorted array
             * Get the ^value^ which is stored under the index = this *value* in your Order array
             * Than the ^value^ is the index in Sorted array
             * Put the *value* below this index in Sorted array
             * Decrease the ^value^ by one
             * 
             * Index    U[uindex] /->O[uvalue] /->S[ovalue]
             * Value    U[uvalue]/   O[ovalue]/   S[uvalue]
             *               |_______________________^
            */
            for (int i = Size-1; i >= 0; --i)
            {
                final[indexList[ArraySorted[i]]-1] = ArraySorted[i];
                indexList[ArraySorted[i]]--;
            }
            return final;
        }
    }
}
