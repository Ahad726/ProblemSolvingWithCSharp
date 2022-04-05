using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    // https://leetcode.com/problems/first-missing-positive/
    internal class First_Missing_Positive
    {
        static void Main(string[] args)
        {
            int[] arr = { 1 };

            var missingNumber = FirstMissingPositive(arr);

            Console.WriteLine(missingNumber);
        }

        public static int FirstMissingPositive(int[] nums)
        {
            int i = 0;
            int n = nums.Length;
            while (i < nums.Length)
            {
                if (nums[i] > 0 && nums[i] <= n)
                {
                    int correctIndex = nums[i] - 1;

                    if (nums[i] != nums[correctIndex])
                    {
                        Swap(nums, i, correctIndex);
                    }
                    else
                    {
                        i++;
                    }
                }
                else
                {
                    i++;
                }
                
            }

            int result = 1;

            for (int j = 0; j < n; j++)
            {
                if (nums[j] == j+1)
                {
                    result++;
                    
                }
                
            }

            return result;
        }

        private static void Swap(int[] nums, int i, int correctIndex)
        {
            int temp = nums[i];
            nums[i] = nums[correctIndex];
            nums[correctIndex] = temp;
        }
    }
}
