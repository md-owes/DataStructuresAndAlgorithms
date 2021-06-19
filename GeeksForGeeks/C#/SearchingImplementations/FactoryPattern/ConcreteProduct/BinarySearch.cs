using SearchingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingImplementations
{
    public class BinarySearch : ISearch
    {
        public int Search(int[] arr, int x)
        {
            int l, r;
            Array.Sort(arr);

            l = 0; r = arr.Length - 1;
            return BinarySearchMethod(arr, l, r, x);
        }

        private int BinarySearchMethod(int[] arr, int l, int r, int num)
        {
            while (l <= r)
            {
                int mid = (l + (r - 1)) / 2;

                if (arr[mid] == num)
                    return mid;

                else if (arr[l] == num)
                    return l;

                else if (arr[r] == num)
                    return r;

                if (num > arr[mid])
                {
                    l = mid + 1;
                    r--;
                }
                else
                {
                    r = mid - 1;
                    l++;
                }
                BinarySearchMethod(arr, l, r, num);
            }

            return -1;
        }
    }
}
