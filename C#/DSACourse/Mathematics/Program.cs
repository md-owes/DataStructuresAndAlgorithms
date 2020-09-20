using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            ExecuteNumberOfDigitsInGivenNumber(12345678);
        }

        private static void ExecuteNumberOfDigitsInGivenNumber(int n)
        {
            NumberOfDigitsInGivenNumber obj = new NumberOfDigitsInGivenNumber();
            int iterativeResult = obj.GetDigitsUsingIterativeApproach(n);
            int recursiveResult = obj.GetDigitsUsingRecursiveApproach(n);
            int logResult = obj.GetDigitsUsingLogarithmicApproach(n);

            Console.WriteLine($"The number of digits for the given number {n} using iterative approach is {iterativeResult}");
            Console.WriteLine($"The number of digits for the given number {n} using recursive approach is {recursiveResult}");
            Console.WriteLine($"The number of digits for the given number {n} using logarithmic approach is {logResult}");
        }
    }
}
