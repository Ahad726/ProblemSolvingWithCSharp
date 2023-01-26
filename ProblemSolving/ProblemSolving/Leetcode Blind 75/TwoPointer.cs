using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class TwoPointer
    {
        static void Main(string[] args)
        {

            Console.WriteLine(IsPalindrome("0P"));
            Console.WriteLine(IsPalindrome("A man, a plan, a canal: Panama"));
            Console.WriteLine(IsPalindrome("race a car"));
        }

        public static bool IsPalindrome(string s)
        {

            int left = 0;
            int right = s.Length - 1;
            while (left < right)
            {
                

                if (!char.IsLetterOrDigit(s[left]))
                {
                    left++;
                    continue;
                }
                if (!char.IsLetterOrDigit(s[right]))
                {
                    right--;
                    continue;
                }
                else if (char.ToLower(s[left]) != char.ToLower(s[right]))
                {
                    return false;
                }
                else
                {
                    left++;
                    right--;
                }
            }

            return true;

        }
    }
}
