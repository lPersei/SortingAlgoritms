using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the MergeSort algorithm
    /// </summary>
    class MergeSort
    {
        /// <summary>
        /// Main method
        /// </summary>
        public IList<T> GetSortedArray<T>(IList<T> ArraySorted) where T : IComparable
        {
            ArraySorted = Merging(ArraySorted);
            return ArraySorted;
        }

        public IList<T> Merging<T>(IList<T> UnsortedList) where T : IComparable
        {
            if (UnsortedList.Count <= 1)
            {
                return UnsortedList;
            }
            IList<T> Left = new List<T>();
            IList<T> Right = new List<T>();

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

        public IList<T> Merge<T>(IList<T> Left,IList<T> Right) where T : IComparable
        {
            IList<T> MergedList = new List<T>();

            while (Left.Count > 0 || Right.Count > 0)
            {
                if (Left.Count > 0 && Right.Count > 0)
                {
                    if (Left.First().CompareTo(Right.First()) <= 0)  //Comparing First two elements to see which is smaller
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
