using System;

namespace Introduction
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
            Console.WriteLine("Hello world!");
            // for (int i = 0; i < n; i++)
            // {
            //     Console.WriteLine("*");
            // }
            //Asymptotic Analysis is log(n) for any value of n, Means if n is 128 then this loop will run 8 times 
            //executing 2 statements in each loop
            //Asymptotic analysis f(n) = (c1*log2(n)+1), log base-2 to 128 gives 7, plus 1 is 8 * 2 = 16
            //c1 = 2 (c1 is n<=1 and print Hello world!)
            RecursivePrint(n / 2);
        }

        public void RecursivePrintWithALoop(int n)
        {
            if (n <= 1)
            {
                return;
            }
            Console.WriteLine("Hello world!");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("*");
            }
            //Asymptotic Analysis is (nlogn) for any value of n, Means if n is 128 then for loop will run 8 times, 
            //1st loop it prints 8 times, 2nd loop prints 4 times, 3rd loop 2 times and last loop 1 time, so 2n-1
            //Asymptotic analysis f(n) = (c1*log2(n)+1)+c2*(2n-1), log base-2 to 128 gives 7, plus 1 is 8 * 2 = 16
            //c1 = 3 (c1 is n<=1, i=0 and print Hello world!), c2=4 (c2 is i<n, i+1, i={i+1}, print *)
            RecursivePrint(n / 2);
        }
    }
}