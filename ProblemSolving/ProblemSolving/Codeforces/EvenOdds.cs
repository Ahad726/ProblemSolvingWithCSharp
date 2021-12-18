using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving
{
    public class EvenOdds
    {
        static void Main(string[] args)
        {
            var line = Console.ReadLine().Split(' ');
            var n = Convert.ToInt64(line[0]);
            var k = Convert.ToInt64(line[1]);

            var middleNumberPosition = n % 2 == 0 ? n / 2 : (n / 2) + 1;

            if (k > middleNumberPosition)
            {
                // kth number is odd
                var diffWithKAndMid = k - middleNumberPosition;
                var diff = middleNumberPosition - diffWithKAndMid;
                var kthNumber = k - diff;
                Console.WriteLine(kthNumber);

            }
            else
            {
                var kthNumber = k + (k - 1);
                Console.WriteLine(kthNumber);
            }
        }
    }
}
