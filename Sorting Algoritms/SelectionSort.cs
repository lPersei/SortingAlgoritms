using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the SelectionSort
    /// </summary>
    class SelectionSort : Sorter
    {
        public void sort()
        {
            List<int> UnsortedList = SortedItemsList;
            List<int> SortedList = new List<int>();

            int min; //min element in Unsorted array
            
            while (UnsortedList.Count != 1) //While list size less than 1
            {
                min = UnsortedList[0]; //Let the min = first element
                int index = 0; //Let the index to remove at Unsorted array = index of the first element
                for (int i = 1; i < UnsortedList.Count; ++i) //Starting from the second item in array, checks which element is lesser 
                {
                    if (min < UnsortedList[i])
                    {
                        continue;
                    }
                    else
                    {
                        min = UnsortedList[i];
                        index = i; //Index of lesser element`s value
                    }

                }
                SortedList.Add(min); //Add element to the list
                UnsortedList.RemoveAt(index); //Remove element from Unsorted array
            }
            SortedList.Add(UnsortedList[0]); //Add the last element in the Unsorted array

            SortedItemsList = SortedList;
        }
    }
}
