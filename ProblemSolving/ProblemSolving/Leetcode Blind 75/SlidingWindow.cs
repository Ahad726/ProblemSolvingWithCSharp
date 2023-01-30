using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class SlidingWindow
    {
        static void Main(string[] args)
        {
            //var rslt1 = LengthOfLongestSubstring("abcabcbb");

            //var length = CharacterReplacement("ABAA", 0);
            var length = CharacterReplacement("AABABBA", 1);

            Console.WriteLine(length);
        }

        public static int CharacterReplacement(string s, int k)
        {
            var result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                var tempChr = s[i];
                var tempK = k;
                var tempL = 0;

                // left
                for (int j = i; j > -1; j--)
                {
                    if(tempChr == s[j])
                    {
                        tempL++;
                    }
                    else if(tempK != 0)
                    {
                        tempL++;
                        tempK--;
                    }
                    else
                    {
                        break;
                    }
                }

                //right
                for (int j = i + 1; j < s.Length; j++)
                {
                    if(tempChr == s[j])
                    {
                        tempL++;
                    }
                    else if(tempK != 0)
                    {
                        tempL++;
                        tempK--;
                    }
                    else
                    {
                        break;
                    }
                }

                result = result > tempL ? result : tempL;
            }
            return result;
        }

        public static int LengthOfLongestSubstring(string s)
        {
            int result = 0;

            var set = new HashSet<char>();
            int l = 0;
            for (int r = 0; r < s.Length; r++)
            {
                while (set.Contains(s[r]))
                {
                    set.Remove(s[l]);
                    l += 1;
                }
                set.Add(s[r]);
                result = Math.Max(result, r - l + 1);
            }
            return result;
        }

        public static int MaxProfit(int[] prices)
        {
            var l = 0;
            var r = l + 1;

            var maxProfit = 0;

            while (r < prices.Length)
            {
                if (prices[l] < prices[r])
                {
                    var tmp = prices[r] - prices[l];
                    maxProfit = tmp > maxProfit ? tmp : maxProfit;
                    r += 1;
                }
                else
                {
                    // left > right
                    l = r;
                    r += 1;
                }
            }

            return maxProfit;
        }
    }
}
