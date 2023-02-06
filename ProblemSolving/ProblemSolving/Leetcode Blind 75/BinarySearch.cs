using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Leetcode_Blind_75
{
    internal class BinarySearch
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Search(new int[] { 1, 3 }, 3));
        }

        public static int Search(int[] nums, int target)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (nums[mid] == target)
                    return mid;

                // left sorted portion
                if (nums[left] <= nums[mid])
                {
                    if (target > nums[mid])
                    {
                        left = mid + 1;
                    }
                    else
                    {
                        if (target < nums[left])
                        {
                            left = mid + 1;
                        }
                        else
                        {
                            right = mid;
                        }
                    }
                }
                // right sorted portion
                else
                {
                    if (target < nums[mid])
                    {
                        right = mid;
                    }
                    else
                    {
                        if (target > nums[right])
                        {
                            right = mid - 1;
                        }
                        else
                        {
                            left = mid + 1;
                        }
                    }
                }
            }

            return -1;
        }
        public static int FindMin(int[] nums)
        {
            int left = 0;
            int right = nums.Length - 1;

            while (left <= right)
            {
                if (nums[left] <= nums[right])
                {
                    return nums[left];
                }
                int mid = left + (right - left) / 2;

                if (nums[mid] >= nums[left])
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid;
                }
            }

            return 0;

        }
    }
}
