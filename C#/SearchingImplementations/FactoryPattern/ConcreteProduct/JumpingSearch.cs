using SearchingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingImplementations
{
    public class JumpingSearch : ISearch
    {
        public int Search(int[] arr, int x)
        {
            int n = arr.Length;
            Array.Sort(arr);

            short loop, step, prev = 0;
            loop = step = (short)Math.Floor(Math.Sqrt(n));

            while (x > arr[loop])
            {
                prev = loop;
                loop += step;

                if (prev >= n)
                    return -1;
            }

            while (arr[prev] < x)
            {
                prev++;
                if (prev == loop)
                    return -1;
            }

            if (arr[prev] == x)
                return prev;


            return -1;
        }
    }
}
