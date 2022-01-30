using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    // https://leetcode.com/problems/split-array-largest-sum/
    internal class SplitArrayLargestSum
    {
        static void Main(string[] args)
        {
            int[] arr = { 7, 2, 5, 10, 8 };

            Console.WriteLine(SplitArray(arr,2));
        }

        public static int SplitArray(int[] nums, int m)
        {
            int start = 0;
            int end = 0;

            for (int i = 0; i < nums.Length; i++)
            {
                start = Math.Max(start, nums[i]); // in the end of the loop it will contain the max item from the array

                end += nums[i];
            }

            while (start < end)
            {
                // try for middle for potential ans
                int mid = start + (end - start) / 2;

                // calculate how many pieces we can divide this in with this max sum
                int sum = 0;
                int pieces = 1;

                foreach (var num in nums)
                {
                    if (sum + num > mid)
                    {
                        // we cannot add this to this subarray. make new one, then sum = num.
                        sum = num;
                        pieces++;
                    }
                    else
                    {
                        sum += num;
                    }
                }

                if (pieces > m)
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid;
                }


            }
            return start; // here start == end
        }
    }
}
