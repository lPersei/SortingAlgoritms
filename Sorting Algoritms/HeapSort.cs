using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Class that implements Heap Sorting algorithm
    /// </summary>
    class HeapSort : ISorter
    {
        public IList<T> GetSortedArray<T>(IList<T> ArraySorted) where T : IComparable
        {
            int heapSize = ArraySorted.Count;

            int rootIndex = (heapSize - 2) / 2;
            while (rootIndex >= 0)
                Heapify(ref ArraySorted, rootIndex--, heapSize);

            while (heapSize > 0)
            {
                ArraySorted[heapSize - 1] = Pop(ref ArraySorted, heapSize);
                heapSize--;
            }

            return ArraySorted;
        }

        private void Heapify<T>(ref IList<T> nodeSet, int rootIndex, int heapSize) where T : IComparable 
        {
            int leftChildIndex = 2 * rootIndex + 1;
            int rightChildIndex = 2 * rootIndex + 2;

            int largestNodeIndex = rootIndex;

            if (leftChildIndex < heapSize && nodeSet[leftChildIndex].CompareTo(nodeSet[rootIndex]) > 0)
                largestNodeIndex = leftChildIndex;

            if (rightChildIndex < heapSize && nodeSet[rightChildIndex].CompareTo(nodeSet[largestNodeIndex]) > 0)
                largestNodeIndex = rightChildIndex;

            if(largestNodeIndex != rootIndex)
            {
                nodeSet.Swap(rootIndex, largestNodeIndex);
                Heapify(ref nodeSet, largestNodeIndex, heapSize);
            }
        }

        private T Pop<T>(ref IList<T> nodeSet, int heapSize) where T : IComparable
        {
            if (heapSize <= 0)
                return default(T);

            T top = nodeSet[0];

            nodeSet[0] = nodeSet[heapSize - 1];

            Heapify(ref nodeSet, 0, heapSize - 1);

            return top;
        }
    }
}
