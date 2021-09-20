using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Number_Theory
{
    class Divisor
    {
        static void Main(string[] args)
        {
            CountDivisor(36);

        }

        static void CountDivisor(int n)
        {
            int divisorCount = 0;
            for (int i = 1; i * i <= n; i++)
            {
                if (n == i * i)
                {
                    divisorCount += 1;
                }
                else if (n % i == 0)
                {
                    divisorCount += 2;
                }
            }

            Console.WriteLine(divisorCount);
        }
    }
    
}
