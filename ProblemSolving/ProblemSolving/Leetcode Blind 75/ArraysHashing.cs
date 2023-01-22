using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class ArraysHashing
    {
        static void Main(string[] args)
        {
            var output = TwoSum(new int[] { 3,2,4 }, 6);

            Console.WriteLine(String.Join(',', output));
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
