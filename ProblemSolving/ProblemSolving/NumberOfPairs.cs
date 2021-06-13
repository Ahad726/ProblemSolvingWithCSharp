using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving
{
    class NumberOfPairs
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < testCase; i++)
            {
                var line = Console.ReadLine().Split(' ');
                var n = Convert.ToInt32(line[0]);
                var leftBound = Convert.ToInt32(line[1]);
                var rightBound = Convert.ToInt32(line[2]);

                var numbersArray = Console.ReadLine().Split(' ').Take(n).Select(Int64.Parse).ToArray();

                Array.Sort(numbersArray);

                int pairCount = 0;

                for (int j = n - 1; j >= 0; j--)
                {
                    for (int k = j-1; k >= 0;  k--)
                    {
                        var number = numbersArray[j] + numbersArray[k];

                        if (leftBound <= number && number <= rightBound)
                        {
                            pairCount++;
                        }
                        else if(leftBound > number)
                        {
                            break;
                        }
                    }
                }

                Console.WriteLine(pairCount);

            }
        }
    }
}
