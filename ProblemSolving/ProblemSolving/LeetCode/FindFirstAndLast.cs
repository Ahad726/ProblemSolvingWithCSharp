using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    public class FindFirstAndLast
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 5, 7, 7, 8, 8, 10 };
            int target = 6;

            var rslt = SearchRange(arr, target);

            Console.WriteLine($"[{rslt[0]},{rslt[1]}]");
        }

        public static int[] SearchRange(int[] nums, int target)
        {
            int[] result = { -1, -1 };

            result[0] = search(nums, target, findStartIndex: true);
            if (result[0] != -1)
            {
                result[1] = search(nums, target, findStartIndex: false);
            }

            return result;
        }

        public static int search(int[] nums, int target, bool findStartIndex)
        {
            int start = 0;
            int end = nums.Length - 1;
            int ans = -1;

            while (start <= end)
            {
                int midIndex = start + (end - start) / 2;
                int mid = nums[midIndex];

                if (mid < target)
                {
                    start = midIndex + 1;
                }
                else if (mid > target)
                {
                    end = midIndex - 1;
                }
                else
                {

                    ans = midIndex;

                    if (findStartIndex)
                    {
                        end = midIndex - 1;
                    }
                    else
                    {
                        start = midIndex + 1;
                    }

                }
            }
            return ans;
        }
    }
}
