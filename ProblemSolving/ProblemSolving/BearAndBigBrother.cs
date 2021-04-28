using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    class BearAndBigBrother
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            int limakWeight = Convert.ToInt32(line[0]);
            int bobWeight = Convert.ToInt32(line[1]);

            int yearCount = 0;

            while (limakWeight <= bobWeight)
            {
                limakWeight = 3 * limakWeight;
                bobWeight = 2 * bobWeight;
                yearCount++;
            }

            Console.WriteLine(yearCount);

        }
    }
}
