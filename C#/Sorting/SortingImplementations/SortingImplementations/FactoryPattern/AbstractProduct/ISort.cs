using System;
using System.Collections.Generic;
using System.Text;

namespace SortingImplementations.FactoryPattern.AbstractProduct
{
    public interface ISwap
    {
        void Swap(ref int x, ref int y);
    }

    public interface ISort : ISwap
    {
        void Sort(int[] arr);
    }

}
