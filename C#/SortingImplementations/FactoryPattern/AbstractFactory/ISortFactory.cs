using SortingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingImplementations.FactoryPattern.AbstractFactory
{
    public interface ISortFactory
    {
        ISort GetSort(string sort);
    }
}
