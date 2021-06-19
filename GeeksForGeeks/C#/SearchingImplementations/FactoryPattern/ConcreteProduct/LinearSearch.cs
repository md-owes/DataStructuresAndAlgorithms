using SearchingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingImplementations
{
    public class LinearSearch : ISearch
    {
        public int Search(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                    return i;
            }

            return -1;
        }
    }
}
