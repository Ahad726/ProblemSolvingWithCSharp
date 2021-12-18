using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ProblemSolving.Codeforces
{
    class ArrayEversion
    {
        static void Main(string[] args)
        {
            int testCase = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < testCase; i++)
            {
                int arraySize = Convert.ToInt32(Console.ReadLine());
                var numArray = Console.ReadLine().Split(' ').Take(arraySize).Select(int.Parse).ToArray();

                var count = 0;
                var largestNum = numArray[arraySize-1];
                for (int j = arraySize-1; j >= 0; j--)
                {
                    if (numArray[j] > largestNum)
                    {
                        largestNum = numArray[j];
                        count++;
                    }
                }

                Console.WriteLine(count);
            }
        }
    }
}
