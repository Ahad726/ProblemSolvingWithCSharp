using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Number_Theory
{
    public class PrimalityTest
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var b = Convert.ToInt64(Console.ReadLine());
                Console.WriteLine(IsPrime(b));
            }
        }

        static bool IsPrime(long n)
        {
            if (n ==1)
            {
                return false;
            }
            for (int i = 2; i*i <= n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;

        }
    }
}
