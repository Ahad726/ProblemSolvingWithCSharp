using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Number_Theory
{
    public class PrimeFactorization
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var n = Convert.ToInt32(Console.ReadLine());

                var factors = GeneratePrimeFactor(n);

                foreach (var nmbr in factors)
                {
                    Console.Write(nmbr + " ");
                }
                Console.WriteLine();
            }



            static List<int> GeneratePrimeFactor(int n)
            {
                var factorList = new List<int>();

                for (int i = 2; i * i < n; i++)
                {
                    while (n % i == 0)
                    {
                        n /= i;
                        factorList.Add(i);
                    }
                }

                if (n > 1)
                {
                    factorList.Add(n);
                }
                return factorList;
            }

        }
    }
}
