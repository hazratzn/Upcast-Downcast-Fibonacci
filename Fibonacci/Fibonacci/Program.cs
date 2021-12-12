using System;
using Fibonacci;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            FibonacciAlgorithm calcfibo = new FibonacciAlgorithm();
            calcfibo.Fibonacci_Iterative(17000000);
        }
    }
}
