using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the MergeSort algorithm
    /// </summary>
    class MergeSort : Sorter
    {
        /// <summary>
        /// Main method
        /// </summary>
        public void sort()
        {
            SortedItemsList = Merging(SortedItemsList);           
        }

        public List<int> Merging(List<int> UnsortedList)
        {
            if (UnsortedList.Count <= 1)
            {
                return UnsortedList;
            }
            List<int> Left = new List<int>();
            List<int> Right = new List<int>();

            int middle = UnsortedList.Count / 2;
            for (int i = 0; i < middle; ++i)
            {
                Left.Add(UnsortedList[i]);
            }
            for (int i = middle; i < UnsortedList.Count; ++i)
            {
                Right.Add(UnsortedList[i]);
            }

            Left = Merging(Left);
            Right = Merging(Right);
            return Merge(Left, Right);
        }

        public List<int> Merge(List<int> Left, List<int> Right)
        {
            List<int> MergedList = new List<int>();

            while (Left.Count > 0 || Right.Count > 0)
            {
                if (Left.Count > 0 && Right.Count > 0)
                {
                    if (Left.First() <= Right.First())  //Comparing First two elements to see which is smaller
                    {
                        MergedList.Add(Left.First());
                        Left.Remove(Left.First());      //Rest of the list minus the first element
                    }
                    else
                    {
                        MergedList.Add(Right.First());
                        Right.Remove(Right.First());
                    }
                }
                else if (Left.Count > 0)
                {
                    MergedList.Add(Left.First());
                    Left.Remove(Left.First());
                }
                else if (Right.Count > 0)
                {
                    MergedList.Add(Right.First());

                    Right.Remove(Right.First());
                }
            }
            return MergedList;
        }
    }
}
