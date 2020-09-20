using System;

namespace Mathematics
{
    public class NumberOfDigitsInGivenNumber
    {

        public NumberOfDigitsInGivenNumber() { }

        public int GetDigitsUsingIterativeApproach(int n)
        {
            int count = 0;
            while (n != 0)
            {
                n = n / 10;
                ++count;
            }
            return count;
        }

        public int GetDigitsUsingRecursiveApproach(int n)
        {
            if (n == 0)
            {
                return 0;
            }
            return 1 + GetDigitsUsingRecursiveApproach(n / 10);
        }

        public int GetDigitsUsingLogarithmicApproach(int n)
        {
            return (int)Math.Floor(Math.Log10(n) + 1);
        }
    }
}