using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class ArraysHashing
    {
        static void Main(string[] args)
        {
            //var output = TwoSum(new int[] { 3,2,4 }, 6);

            //Console.WriteLine(String.Join(',', output));

            var isAnagram = IsAnagram("anagram", "nagaram");
            //var isAnagram = IsAnagram("Rat", "cat");
            Console.WriteLine(isAnagram);
        }

        public static bool IsAnagram(string s, string t)
        {
            var sdict = new Dictionary<char, int>();
            var tdict = new Dictionary<char, int>();

            if (s.Length != t.Length)
                return false;
            if (s == t)
                return true;

            for (int i = 0; i < s.Length; i++)
            {
                sdict[s[i]] = 1 + (sdict.ContainsKey(s[i]) ? sdict[s[i]] : 0);  // if condition is true then the code can be simplified as sdict[s[i]] = 1 +sdict[s[i]]
                tdict[t[i]] = 1 + (tdict.ContainsKey(t[i]) ? tdict[t[i]] : 0);
            }

            foreach (var ch in sdict.Keys)
            {
                int tCount = tdict.ContainsKey(ch) ? tdict[ch] : 0; 

                if (tCount != sdict[ch])
                {
                    return false;
                }
            }
            return true;
        }

        public bool ContainsDuplicate(int[] nums)
        {
            var set = new HashSet<int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (set.Contains(nums[i]))
                    return true;
                set.Add(nums[i]);
            }
            return false;
        }


        public static int[] TwoSum(int[] nums, int target)
        {
            var dictionary = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var curr = nums[i];
                var dif = target - curr;

                if (dictionary.ContainsKey(dif))
                {
                    return new int[] { dictionary[dif], i };
                }
                else
                {
                    dictionary[nums[i]] = i;
                }
            }

            return null;
        }

    }
}
