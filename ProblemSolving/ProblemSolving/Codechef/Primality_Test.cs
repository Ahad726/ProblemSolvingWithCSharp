using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class Primality_Test
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var b = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(IsPrime(b));
            }
        }

        static string IsPrime(int n)
        {
            if (n ==1)
            {
                return "no";
            }

            for (int i = 2; i*i <= n; i++)
            {
                if (n % i == 0)
                    return "no";
            }

            return "yes";
        }
    }
}
