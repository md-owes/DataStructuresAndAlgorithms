using SortingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingImplementations
{
    public class BubbleSort : ISort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                bool isSorted = false;
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        Helper.Swap(ref arr[j], ref arr[j + 1]);
                        isSorted = true;
                    }
                }
                if (!isSorted)
                    break;
            }
        }
    }
}
