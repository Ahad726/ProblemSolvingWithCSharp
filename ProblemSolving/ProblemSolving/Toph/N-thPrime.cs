using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Toph
{
    class N_thPrime
    {
        public static List<int> PrimeList = new List<int>();
        public static int[] allNumbers = new int[500001];

        static void Main(string[] args)
        {
            Sieve();
            var n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(PrimeList[n-1]);

        }

        static void Sieve()
        {
            allNumbers[0] = allNumbers[1] = 1;
            
            for (int i = 3; i * i <= 500000; i += 2)
            {
                if (allNumbers[i] == 0)
                {
                    for (int j = i * i; j <= 500000; j += i)
                    {
                        allNumbers[j] = 1;
                    }
                }

            }

            PrimeList.Add(2);
            for (int i = 3; i <= 500000; i += 2)
            {
                if (allNumbers[i] == 0)
                {
                    PrimeList.Add(i);
                }
            }
        }
    }
}
