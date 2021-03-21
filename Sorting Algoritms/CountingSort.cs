using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting_Algoritms
{
    class CountingSort
    {
        public void GetSortedArray(IList<int> ArraySorted)
        {
            int Size = ArraySorted.Count;
            int Max = ArraySorted.Max();
            int[] indexList = new int[Max+1];
            //Count number of occurances for each value
            for (int i = 0; i < ArraySorted.Count; ++i)
            {
                indexList[ArraySorted[i]]++;
            }
            //magic
            for (int i = 0; i < indexList.Length-1; ++i)
            {
                indexList[i + 1] = indexList[i] + indexList[i + 1];
            }
            //Array for sorted values
            IList<int> final = new List<int>();
            foreach(int x in ArraySorted)
            {
                final.Add(x);
            }
            
            for (int i = Size-1; i >= 0; --i)
            {
                final[indexList[ArraySorted[i]]-1] = ArraySorted[i];
                indexList[ArraySorted[i]]--;
            }
            ArraySorted = final;
        }
    }
}
