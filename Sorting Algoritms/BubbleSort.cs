using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    public class BubbleSort : Sorter
    {
        public void sort()
        {            
            bool swapped = true;
            int Size = SortedItemsList.Count;

            while (swapped == true) {
                swapped = false;
                for (int i = 0; i < Size - 1; ++i)
                {
                    if (SortedItemsList[i].CompareTo(SortedItemsList[i + 1]) == 1)
                    {
                        Swap(i, i+1);
                        swapped = true;
                    }
                }
            }
        }
    }
}
