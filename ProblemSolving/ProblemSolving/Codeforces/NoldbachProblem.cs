using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class NoldbachProblem
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            var n = Convert.ToInt32(line[0]);
            var k = Convert.ToInt32(line[1]);

            var primes = Sieve(n);

            int count = 0;

            for (int i = 0; i < primes.Count -1; i++)
            {
                var sum = primes[i] + primes[i + 1] + 1;
                if (sum > n)
                {
                    break;
                }
                if (IsPrime(sum))
                {
                    count++;
                }
            }

            var result = count >= k ? "YES" : "NO";
            Console.WriteLine(result);
        }

        static List<int> Sieve(int n)
        {
            var primeArray = new int[n + 1];

            primeArray[0] = primeArray[1] = 1;

            for (int i = 2; i * i <= n; i++)
            {
                if (primeArray[i] == 0)
                {
                    for (int j = i * i; j <= n; j += i)
                    {
                        primeArray[j] = 1;
                    }
                }
            }

            var primeList = new List<int>();

            for (int i = 0; i <= n; i++)
            {
                if (primeArray[i] == 0)
                {
                    primeList.Add(i);
                }
            }

            return primeList;
        }

        static bool IsPrime(int n)
        {
            for (int i = 2; i * i <= n; i++)
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
