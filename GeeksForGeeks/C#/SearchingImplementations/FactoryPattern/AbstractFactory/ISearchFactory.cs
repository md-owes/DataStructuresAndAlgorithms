using SearchingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingImplementations.FactoryPattern.AbstractFactory
{
    public interface ISearchFactory
    {
        ISearch GetSearch(string search);
    }
}
