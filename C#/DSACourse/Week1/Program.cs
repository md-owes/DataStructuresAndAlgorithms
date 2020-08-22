using System;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            SumOfnNumbers obj = new SumOfnNumbers();
            int formulaResult = obj.SumUsingFormula(10);
            int singleLoopResult = obj.SumUsingSingleLoop(10);
            int multipleLoopResult = obj.SumUsingMultipleLoop(10);

            Console.WriteLine($"The output of formula approach is {formulaResult}");
            Console.WriteLine($"The output of singleloop approach is {singleLoopResult}");
            Console.WriteLine($"The output of multipleloop approach is {multipleLoopResult}");
        }
    }
}
