using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class FindSmallestGreaterThanTarget
    {
        static void Main(string[] args)
        {
            char[] letters = { 'c', 'f', 'j' };

            Console.WriteLine(NextGreatestLetter(letters, 'c'));
        }

        static char NextGreatestLetter(char[] letters, char target)
        {
            int start = 0;
            int end = letters.Length - 1;
            while (start <= end)
            {
                int midIndex = start + (end - start) / 2;
                char mid = letters[midIndex];

                if (mid > target)
                {
                    end = midIndex - 1;
                }
                else
                {
                    start = midIndex + 1;
                }
            }
            return letters[start % letters.Length];
        }
    }
}
