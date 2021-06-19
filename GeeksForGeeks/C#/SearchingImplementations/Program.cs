using SearchingImplementations.FactoryPattern.AbstractFactory;
using SearchingImplementations.FactoryPattern.AbstractProduct;
using SearchingImplementations.FactoryPattern.ConcreteFactory;
using System;

namespace SearchingImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string input = Console.ReadLine();
                int searchItem = Convert.ToInt16(Console.ReadLine());
                string[] strArray = input.Split(" ");
                int[] intArray = Array.ConvertAll(strArray, int.Parse);
                ISearchFactory factoryObj = new SearchFactory();
                ISearch searchObj = factoryObj.GetSearch("jump");
                int index = searchObj.Search(intArray, searchItem);
                Console.Write("Searched Array => ");
                Array.ForEach(intArray, k => Console.Write(k + " "));
                Console.WriteLine();
                Console.WriteLine(index != -1 ? string.Format("The search item {0} found at index {1}", searchItem, index) : string.Format("Unable to find search item in the array"));
            }
            catch (Exception ex)
            {
                Console.WriteLine(string.Format("Exception occurred, details are {0}", ex.Message));
            }

            Console.ReadKey();
        }
    }
}
