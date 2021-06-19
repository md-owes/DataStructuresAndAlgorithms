using System;

namespace Mathematics
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteNumberOfDigitsInGivenNumber(12345678);
            ExecuteArithmeticProgression(10);
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

        private static void ExecuteArithmeticProgression(int n)
        {
            ArithmeticProgression obj = new ArithmeticProgression();
            int arithmeticResult = obj.GetArithmeticProgressionOfSeries2(n, 2, 2);
            double geometricResult = obj.GetGeometricProgressionOfSeries2(n, 2, 2);
            Console.WriteLine($"The sum of given number {n} in arithmetic progression with starting number 2 and difference 2 is {arithmeticResult}");
            Console.WriteLine($"The sum of given number {n} in geometric progression with starting number 2 and difference 2 is {geometricResult}");
        }
    }
}
