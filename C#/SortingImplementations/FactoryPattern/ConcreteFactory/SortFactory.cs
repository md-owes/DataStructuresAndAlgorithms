using SortingImplementations.FactoryPattern.AbstractFactory;
using SortingImplementations.FactoryPattern.AbstractProduct;
using System;
using System.Collections.Generic;
using System.Text;

namespace SortingImplementations.FactoryPattern.ConcreteFactory
{
    public class SortFactory : ISortFactory
    {
        public ISort GetSort(string search)
        {
            switch(search)
            {
                case "selection":
                    return new SelectionSort();
                case "bubble":
                    return new BubbleSort();
                case "jump":
                    return new JumpingSearch();
                default:
                    throw new NotImplementedException(string.Format("Unable to create search object for {0}", search));
            }
        }
    }
}
