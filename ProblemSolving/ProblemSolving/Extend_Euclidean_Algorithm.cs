using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class Extend_Euclidean_Algorithm
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            var a = Convert.ToInt32(line[0]);
            var b = Convert.ToInt32(line[1]);

            int x = 1;
            int y = 1;

            extended_gcd(a, b,ref x, ref y);

            Console.WriteLine($"{x} {y}");
        }

        static int extended_gcd(int a, int b, ref int x, ref int y)
        {
            // Base Case
            if (b == 0)
            {
                x = 1;
                y = 0;
                return a;
            }

            int x1=1, y1=1;

            int d = extended_gcd(b, a % b, ref x1, ref y1);

            // Update x and y using
            // results of recursive call
            x = y1;
            y = x1 - y1 * (a / b);
            return d;
        }
    }

}
