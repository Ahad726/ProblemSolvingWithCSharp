using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class ExcitingBets
    {
        static void Main(string[] args)
        {
            var n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var a = Convert.ToInt64(line[0]);
                var b = Convert.ToInt64(line[1]);

                if (a == b)
                {
                    Console.WriteLine("0 0");
                    continue;
                }

                var x = a;
                var y = b;

                var dif = a >= b ? a - b : b - a;



                var gcd = GCD(a, b);
                int upCount = 0;
                while (gcd != dif)
                {
                    a++;
                    b++;
                    upCount++;
                    gcd = GCD(a, b); 
                }

                int lowCount = 0;
                var gcdInLow = GCD(x, y);
                while (gcdInLow != dif)
                {
                    a--;
                    b--;
                    lowCount++;
                    gcdInLow = GCD(a, b);
                }

                if (upCount < lowCount)
                {
                    Console.WriteLine($"{gcd} {upCount}");
                }
                else
                {
                    Console.WriteLine($"{gcdInLow} {lowCount}");
                }
                
            }
        }

        static long GCD(long a, long b)
        {
            while (a > 0 && b > 0)
            {
                if (a >= b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return Math.Max(a, b);
        }
    }
}
