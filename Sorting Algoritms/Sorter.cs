﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    public class Sorter
    {
        public static List<int> SortedItemsList = new List<int>();
        public void Swap(int ItemA, int ItemB)
        {
            var tmp = SortedItemsList[ItemA];
            SortedItemsList[ItemA] = SortedItemsList[ItemB];
            SortedItemsList[ItemB] = tmp;
        }
    }
}