using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the SelectionSort
    /// </summary>
    class SelectionSort : ISorter
    {
        public IList<T> GetSortedArray<T>(IList<T> ArraySorted) where T : IComparable
        {
            IList<T> SortedList = new List<T>();

            T min; //min element in Unsorted array
            
            while (ArraySorted.Count != 1) //While list size less than 1
            {
                min = ArraySorted[0]; //Let the min = first element
                int index = 0; //Let the index to remove at Unsorted array = index of the first element
                for (int i = 1; i < ArraySorted.Count; ++i) //Starting from the second item in array, checks which element is lesser 
                {
                    if (min.CompareTo(ArraySorted[i]) < 0)
                    {
                        continue;
                    }
                    else
                    {
                        min = ArraySorted[i];
                        index = i; //Index of lesser element`s value
                    }

                }
                SortedList.Add(min); //Add element to the list
                ArraySorted.RemoveAt(index); //Remove element from Unsorted array
            }
            SortedList.Add(ArraySorted[0]); //Add the last element in the Unsorted array

            return SortedList;
        }
    }
}
