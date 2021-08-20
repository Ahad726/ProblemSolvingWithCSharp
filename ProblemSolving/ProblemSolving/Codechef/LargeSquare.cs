using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class LargeSquare
    {
        static void Main(string[] args)
        {
            var t = Convert.ToInt32(Console.ReadLine());

            for (int tstCase = 0; tstCase < t; tstCase++)
            {
                var line = Console.ReadLine().Split(' ');
                var n = Convert.ToInt64(line[0]);
                var a = Convert.ToInt64(line[1]);

                var sqrtOfn = (int)Math.Sqrt(n);

                Console.WriteLine(sqrtOfn*a);
            }
        }
    }
}
