using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class AlmostPrime
    {
        static void Main(string[] args)
        {
            var m = Convert.ToInt32(Console.ReadLine());

            int count = 0;

            for (int i = 6 ; i <= m; i++)
            {
                var factors = GetUniqPrimeFactors(i);
                if (factors.Count == 2)
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }

        static List<int> GetUniqPrimeFactors(int n)
        {
            var primesFactor = new List<int>();

            for (int i = 2; i * i <= n; i++)
            {
                while (n % i == 0)
                {
                    n /= i;

                    if (!primesFactor.Contains(i))
                    {
                        primesFactor.Add(i);
                    }
                }
               
            }

            if (n > 1)
            {
                if (!primesFactor.Contains(n))
                {
                    primesFactor.Add(n);
                }
            }

            return primesFactor;
        }
    }
}
