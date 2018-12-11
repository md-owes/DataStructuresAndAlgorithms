using SortingImplementations.FactoryPattern.AbstractFactory;
using SortingImplementations.FactoryPattern.AbstractProduct;
using SortingImplementations.FactoryPattern.ConcreteFactory;
using System;

namespace SortingImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                string[] strArray = input.Split(" ");
                int[] intArray = Array.ConvertAll(strArray, int.Parse);
                ISortFactory factoryObj = new SortFactory();
                ISort sortObj = factoryObj.GetSort("selection");
                sortObj.Sort(intArray);
                Console.Write("Sorted Array => ");
                Array.ForEach(intArray, k => Console.Write(k + " "));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception occurred, details are {0}", ex.Message));
            }

            Console.ReadKey();
        }
    }
}
