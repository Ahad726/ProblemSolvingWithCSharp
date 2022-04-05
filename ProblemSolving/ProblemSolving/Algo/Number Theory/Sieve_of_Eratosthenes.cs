using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Number_Theory
{
    class Sieve_of_Eratosthenes  // Prime Generator 1 to n 
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());

            var nmbrArray = Sieve(n);

          

            for (int i = 0; i < nmbrArray.Length; i++)
            {
                if (nmbrArray[i] == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }

        static int[] Sieve(int n)
        {
            var primeGntr = new int[n+1]; // as default 0, so if 0 then prime , 1 then not prime

            primeGntr[0] = primeGntr[1] = 1;

            for (int i = 2; i * i <= n; i++)
            {
                if (primeGntr[i] == 0) // if prime 
                {
                    for (int j = i * i; j <= n; j+= i)      // we are marking from i*i because multiples of i before i*i already marked. if i = 5, then 
                                                            // 10,15,20 is already marked before coming to i = 5; therefore we start marking from i *i;
                    {
                        primeGntr[j] = 1; // marked as not prime
                    }
                }
            }

            return primeGntr;

        }
    }
}
