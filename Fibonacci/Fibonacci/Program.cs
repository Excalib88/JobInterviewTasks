using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input N: ");
            var iterativeFib = new FibonacciRecursive();
            var result = iterativeFib.Calculate(4);

            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
