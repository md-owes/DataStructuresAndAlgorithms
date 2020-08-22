using System;

namespace Week1
{
    public class Recursion
    {
        public Recursion() { }

        public void RecursivePrint(int n)
        {
            if (n <= 1)
            {
                return;
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*");
            }
            RecursivePrint(n / 2);
        }
    }
}