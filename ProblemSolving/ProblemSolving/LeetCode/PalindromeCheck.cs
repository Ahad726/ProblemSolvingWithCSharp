using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class PalindromeCheck
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome("abccba"));
        }

        static bool IsPalindrome(string str)
        {
            str = str.ToLower();
            for (int i = 0; i < str.Length / 2; i++)
            {
                var start = str[i];
                var end = str[str.Length - 1 - i];

                if (start != end)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
