using System;
using System.Collections.Generic;
using System.Text;

namespace SortingImplementations
{
    public static class Helper
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
