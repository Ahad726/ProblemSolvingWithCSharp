using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class LetterOfCombination
    {
        static void Main(string[] args)
        {
            string digits = Console.ReadLine();
            string[] strArray = { "0", "1", "abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz" };
            Dictionary<char, string> strDic = new Dictionary<char, string>
            {
                { '2', "abc" },
                { '3', "def" },
                { '4', "ghi" },
                { '5', "jkl" },
                { '6', "mno" },
                { '7', "pqrs" },
                { '8', "tuv" },
                { '9', "wxyz" }
            };
            var ans = new List<string>();
            BackTracking(digits,strDic,0,new StringBuilder(), ans);
            foreach (var item in ans)
            {
                Console.WriteLine(item);
            }

        }
        public static void BackTracking(string digits, Dictionary<char, string> strDic , int index,StringBuilder sb, IList<string> ans )
        {
            if (index == digits.Length)
            { 
                ans.Add(sb.ToString());
                return;
            }

            var ch = digits[index];
            var curr = strDic[ch];
            for (int j = 0; j < curr.Length; j++)
            {
                sb.Append(curr[j]);
                BackTracking(digits, strDic, index+1,sb,ans);
                sb.Remove(sb.Length - 1, 1);
            }

        }

    }
}
