using System;
using System.Collections.Generic;
using System.Text;

namespace Fibonacci
{
    public class FibonacciAlgorithm
    {
        public void Fibonacci_Iterative(int length)
        {
            int a = 0, b = 1, c = 0;
            Console.Write("{0} {1}", a, b);
            for (int i = 2; i < length; i++)
            {
                c = a + b;
                Console.Write(" {0}", c);
                a = b;
                b = c;
            }
        }
    }
}
