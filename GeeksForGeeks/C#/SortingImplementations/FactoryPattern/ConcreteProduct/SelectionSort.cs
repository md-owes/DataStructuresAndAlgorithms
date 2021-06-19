using SortingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingImplementations
{
    public class SelectionSort : ISort
    {
        public void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int index = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[index])
                        index = j;
                }
                Helper.Swap(ref arr[i], ref arr[index]);
            }
        }
    }
}
