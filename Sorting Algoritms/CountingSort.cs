using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algoritms
{
    class CountingSort : Sorter
    {
        int Size = SortedItemsList.Count;
        public void sort()
        {
            int Max = SortedItemsList.Max();
            int[] indexList = new int[Max+1];
            //Count number of occurances for each value
            for (int i = 0; i < SortedItemsList.Count; ++i)
            {
                indexList[SortedItemsList[i]]++;
            }
            //magic
            for (int i = 0; i < indexList.Length-1; ++i)
            {
                indexList[i + 1] = indexList[i] + indexList[i + 1];
            }
            //Array for sorted values
            List<int> final = new List<int>();
            foreach(int x in SortedItemsList)
            {
                final.Add(x);
            }
            
            for (int i = Size-1; i >= 0; --i)
            {
                final[indexList[SortedItemsList[i]]-1] = SortedItemsList[i];
                indexList[SortedItemsList[i]]--;
            }
            SortedItemsList = final;
        }
    }
}
