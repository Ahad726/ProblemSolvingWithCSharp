using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    // https://leetcode.com/problems/find-all-numbers-disappeared-in-an-array/
    internal class DisappearedNumbers
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };

            var missingNum = FindDisappearedNumbers(arr);

            Console.WriteLine(String.Join(',', missingNum));
        }

        public static IList<int> FindDisappearedNumbers(int[] nums)
        {
            int i = 0;
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

            var missingNumList = new List<int>();

            for (int j = 0; j < nums.Length; j++)
            {
                if (nums[j] != j + 1)
                {
                    missingNumList.Add(j+1);
                }
            }

            return missingNumList;
        }

        private static void Swap(int[] arr, int i, int correctIndex)
        {
            int temp = arr[i];
            arr[i] = arr[correctIndex];
            arr[correctIndex] = temp;
        }
    }
}
