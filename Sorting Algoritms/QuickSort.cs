using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Implementation of the QuickSort algorithm
    /// </summary>
    class QuickSort : Sorter
    {
        public void sort()
        {
            //First call of the recursion
            SortSection(0, SortedItemsList.Count - 1);          
        }
        /// <summary>
        /// Recursive method of dividing array into Left and Right sections and sorting 
        /// untill the all of the elements are sorted(All of the pivots are on their
        /// correct place).
        /// </summary>
        /// <param name="L">This is the Beginning of the section ak. Left side.</param>
        /// <param name="R">This is the end of the section ak. Right side.</param>
        private void SortSection(int L, int R)
        {
            //Return if there is only One element in section 
            if (L >= R)
            {
                return;
            }
            //Let the pivot = Right most element of the section
            int pivot = SortedItemsList[R];
            //Remember the starting point of this section and from now L is the Beginning 
            //of the Right section with elements which are bigger than pivot
            int TempL = L;
            // Look through the section from the Left side untill pivot
            for (int i = L; i < R; ++i)
            {
                //if the current element is lesser or equals the pivot, 
                //swap this element with Beginning of the Right section(L)
                if (SortedItemsList[i] <= pivot)
                {
                    Swap(i, L);
                    //Now, Beginning is the next element and swapped item 
                    //is the last element of the Left section(With values lesser than pivot)
                    L++;
                }
            }
            //Swap piwot with the L(Beginning of the Right section)
            //So for now pivot is in it`s correct place
            Swap(L, R);
            //Call the method for the Left and Right section(excluding the pivot of cource)
            SortSection(TempL, L - 1);
            SortSection(L + 1, R);
        }
    }
}
