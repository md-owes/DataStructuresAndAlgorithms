using SearchingImplementations.FactoryPattern.AbstractFactory;
using SearchingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SearchingImplementations.FactoryPattern.ConcreteFactory
{
    public class SearchFactory : ISearchFactory
    {
        public ISearch GetSearch(string search)
        {
            switch(search)
            {
                case "linear":
                    return new LinearSearch();
                case "binary":
                    return new BinarySearch();
                case "jump":
                    return new JumpingSearch();
                default:
                    throw new NotImplementedException(string.Format("Unable to create search object for {0}", search));
            }
        }
    }
}
