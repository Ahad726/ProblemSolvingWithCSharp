using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Number_Theory
{
    public class SegmentedSieve
    {
        public static List<int> Primes = new List<int>();
        private const int MAX = 32000;
        static void Main(string[] args)
        {
            Sieve();
            var t = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < t; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var l = Convert.ToInt64(line[0]);
                var r = Convert.ToInt64(line[1]);

                SegSieve(l, r);
            }

        }

        static void Sieve()
        {
            var isPrime = new bool[MAX];

            for (int i = 0; i < MAX; i++)
            {
                isPrime[i] = true;
            }

            for (int i = 3; i*i <= MAX; i += 2)
            {
                for (int j = i*i; j < MAX; j += i)
                {
                    isPrime[j] = false;
                }
            }

            Primes.Add(2);
            for (int i = 3; i < MAX; i += 2)
            {
                if (isPrime[i])
                    Primes.Add(i);
            }
        }

        static void SegSieve(long l , long r) // l = left , r = right
        {
            var size = r - l + 1;
            var isPrime = new bool[size];
            for (int i = 0; i < size; i++)
            {
                isPrime[i] = true;
            }

            if (l == 1)
            {
                isPrime[0] = false;
            }

            for (int i = 0; Primes[i]* Primes[i] <= r; i++)
            {
                int currentPrime = Primes[i];

                long bse = (l / currentPrime) * currentPrime;
                if (bse < l)
                {
                    bse += currentPrime;
                }

                for (long j = bse; j <= r; j += currentPrime)
                {
                    isPrime[j - l] = false;
                    
                }
                if (bse == currentPrime)
                {
                    isPrime[bse - l] = true;
                }
            }

            for (int i = 0; i < size; i++)
            {
                if(isPrime[i])
                    Console.WriteLine(i+l);
            }
        }
    }
}
