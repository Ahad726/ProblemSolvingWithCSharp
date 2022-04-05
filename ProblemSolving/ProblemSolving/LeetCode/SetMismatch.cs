using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    // https://leetcode.com/problems/set-mismatch/
    internal class SetMismatch
    {
        static void Main(string[] args)
        {
            int[] arr = { 2,1,4,2,6,5 };

            var errorNum = FindErrorNums(arr);

            Console.WriteLine(String.Join(',', errorNum));
        }

        public static int[] FindErrorNums(int[] nums)
        {
            int i = 0;
            var errorNum = new int[2];
            while (i < nums.Length)
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

            for (int j = 0; j < nums.Length; j++)
            {
                if(nums[j] != j + 1)
                {
                    errorNum[0] = nums[j];
                    errorNum[1] = j + 1;
                }
            }
            return errorNum;
        }

        private static void Swap(int[] nums, int i, int correctIndex)
        {
            int temp = nums[i];
            nums[i] = nums[correctIndex];
            nums[correctIndex] = temp;
        }
    }
}
