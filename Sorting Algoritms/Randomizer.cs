using System;
using System.Collections.Generic;
using System.Text;

namespace Sorting_Algoritms
{
    /// <summary>
    /// Class for filling an array with random values
    /// </summary>
    class Randomizer
    {
        Random rnd = new Random();
        public Randomizer()
        {
         
        }

        public List<int> FillWithValues(int numOfItems, int min, int max)
        {
            List<int> listOfRandomValues = new List<int>();
            for (int i = 0; i < numOfItems; ++i)
            {
                listOfRandomValues.Add(rnd.Next(min, max));
            }
            return listOfRandomValues;
        }
        
        
    }
}
