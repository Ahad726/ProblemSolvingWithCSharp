using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Codechef
{
    public class ChefAndSpells
    {
        static void Main(string[] args)
        {
            int t = Convert.ToInt32(Console.ReadLine());

            for (int p = 0; p < t; p++)
            {
                var line = Console.ReadLine().Split(' ');
                var a = Convert.ToInt64(line[0]);
                var b = Convert.ToInt64(line[1]);
                var c = Convert.ToInt64(line[2]);

                long minInAB = Math.Min(a, b);
                long allMin = Math.Min(minInAB, c);

                long totalSum = (a + b + c);

                long result = totalSum - allMin;

                Console.WriteLine(result);
            }
        }
    }
}
