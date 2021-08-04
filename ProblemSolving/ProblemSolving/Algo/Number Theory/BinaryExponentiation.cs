using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Number_Theory
{
    // finding the solution of a^n in O(log(n)) time complexity
    public class BinaryExponentiation
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var b = Convert.ToInt64(line[0]);
                var power = Convert.ToInt64(line[1]);

                var result = CalculatePower(b, power);
                Console.WriteLine($"{b}^{power} = {result}");
            }
        }

        static long CalculatePower(long b, long power)
        {
            long res = 1;

            while (power > 0)
            {
                if (power % 2 != 0)
                {
                    res *= b;
                    power--;
                }
                b *= b;
                power /= 2;
            }
            return res;
        }
    }
}
