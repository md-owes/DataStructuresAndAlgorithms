using System;

namespace Week1
{
    public class SumOfnNumbers
    {
        public SumOfnNumbers() { }

        public int SumUsingFormula(int n)
        {
            // Asymptotic Analysis is constant for all n
            return n * (n + 1) / 2;
        }

        public int SumUsingSingleLoop(int n)
        {
            // Asymptotic Analysis is n for any value of n, Means if n is 100 then this loop will run 100 times
            //Asymptotic analysis f(n) = c1*n+c2
            //c1 = 5, c2 = 2 (c1 is i<=n, i+1, i={i+1}, sum+i, sum={sum+i} and c2 is i=0, sum=0, return sum)
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                sum = sum + i;
            }
            return sum;
        }

        public int SumUsingMultipleLoop(int n)
        {
            // Asymptotic Analysis is n square for any value of n, Means if n is 100 then this loop will run 10000 times
            //Asymptotic analysis f(n) = c1*n*n+c2*n+c3
            //c1 = 5, c2 = 3, c3 = 4 (c1 is j<=i, j+1, j={j+1}, sum+1, sum={sum+1} and c2 is i<=n, i+1, i={i+1} and c3 is j=1, i=1, sum=0, return sum)
            //for n=3, outer loop will execute n=3 times, inner loop will execute n*(n+1)/2=6 times, so a total of 9 executions when n=3 which is n*n.
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    sum++;
                }
            }
            return sum;
        }
    }
}