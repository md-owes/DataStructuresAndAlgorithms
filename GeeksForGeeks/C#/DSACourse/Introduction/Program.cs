using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteSumOfnNumbers(10);
            ExecuteRecursion(8);
        }

        private static void ExecuteSumOfnNumbers(int n)
        {
            SumOfnNumbers obj = new SumOfnNumbers();
            int formulaResult = obj.SumUsingFormula(n);
            int singleLoopResult = obj.SumUsingSingleLoop(n);
            int multipleLoopResult = obj.SumUsingMultipleLoop(n);

            Console.WriteLine($"The output of formula approach is {formulaResult}");
            Console.WriteLine($"The output of singleloop approach is {singleLoopResult}");
            Console.WriteLine($"The output of multipleloop approach is {multipleLoopResult}");
        }

        private static void ExecuteRecursion(int n)
        {
            Recursion obj = new Recursion();
            obj.RecursivePrint(n);
        }
    }
}
