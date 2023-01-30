using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class SlidingWindow
    {
        static void Main(string[] args)
        {
            //var rslt1 = LengthOfLongestSubstring("abcabcbb");

            //var length = CharacterReplacement("ABAA", 0);
            var length = CharacterReplacement("ABABBA", 2);

            Console.WriteLine(length);
        }

        public static int CharacterReplacement(string s, int k)
        {
            var hashMap = new Dictionary<char, int>();
            int l = 0;
            int result = 0;
            var maxFreq = 0;
            for (int r = 0; r < s.Length; r++)
            {
                hashMap[s[r]] = 1 + (hashMap.ContainsKey(s[r]) ? hashMap[s[r]] : 0); // if condition is true then the code can be
                                                                                     // simplified as hashMap[s[i]] = 1 + hashMap[s[i]]
                maxFreq = Math.Max(maxFreq, hashMap[s[r]]);

                if((r - l + 1) - maxFreq > k)   // window size = r - l + 1
                {
                    hashMap[s[l]] -= 1;
                    l += 1;
                }

                result = Math.Max(result, r - l + 1);
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
