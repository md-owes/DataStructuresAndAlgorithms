using System;

namespace Mathematics
{
    public class ArithmeticProgression
    {

        public ArithmeticProgression() { }

        public int GetArithmeticProgressionOfSeries2(int n, int start, int diff) //i.e; find sum of 2,4,6,8,10,12.......n
        {
            //a simple plain formula is n/2(2a+(n-1)d) where a is starting number and d is the difference in progression
            //In our example above a is 2 and d is also 2
            return (n*(2*start+(n-1)*diff)/2);
        }

        public double GetGeometricProgressionOfSeries2(int n, int start, int diff) //i.e; find sum of 2,4,8,16,32,.......n
        {
            //a simple plain formula is a(1-d^n)/(1-n) where a is starting number and d is the difference in progression
            //In our example above a is 2 and d is also 2
            return (start*(1-Math.Pow(diff,n))/(1-diff));
        }
    }
}