using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public class FibonacciRecursive
    {
        public int Calculate(int n)
        {
            if (n == 1 | n == 2) return n - 1;
            
            return Calculate(n - 2) + Calculate(n - 1);
        }
    }
}
