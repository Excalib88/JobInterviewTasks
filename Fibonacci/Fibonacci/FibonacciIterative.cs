using System;
using System.Collections.Generic;
using System.Linq;

namespace Fibonacci
{
    public class FibonacciIterative
    {
        public int Calculate(int n)
        {
            return FibonacciCollection().ElementAt(n - 1);
        }

        IEnumerable<int> FibonacciCollection()
        {
            int x = 0;
            yield return x;
            int y = 1;
            yield return y;

            while (true)
            {
                x = x + y;
                yield return x;
                y = x + y;
                yield return y;
            }
        }

        public int CalculateBine(int n) => (int)((Math.Pow(1.618034, n - 1) - Math.Pow(-0.618034, n - 1)) / Math.Sqrt(5));
    }
}
