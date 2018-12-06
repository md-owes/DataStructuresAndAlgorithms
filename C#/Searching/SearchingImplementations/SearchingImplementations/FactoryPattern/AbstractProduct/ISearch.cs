using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingImplementations.FactoryPattern.AbstractProduct
{
    public interface ISearch
    {
        int Search(int[] arr, int x);
    }
}
