using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Spoj
{
    public class Finding_Kth__Prime
    {

        public static bool[] ar = new bool[90000001];
        public static int[] primeArray = new int[90000000];

        static void Main(string[] args)
        {
            var t = Convert.ToInt64(Console.ReadLine());

            Sieve();

            for (int testCase = 0; testCase < t; testCase++)
            {
                var nth = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(primeArray[nth-1]);
            }

        }

        static void Sieve()
        {
            ar[0] = ar[1] = true;
            for (int i = 2; i*i <= ar.Length; i++)
            {
                if (!ar[i])
                {
                    for (int j = i*i; j < ar.Length; j += i)
                    {
                        ar[j] = true;
                    }
                }
            }

            for (int i = 2; i < ar.Length; i++)
            {
                if (!ar[i])
                {
                    primeArray[i] = i;
                }
            }

        }

    }
}
