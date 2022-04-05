using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    // https://leetcode.com/problems/find-all-duplicates-in-an-array/
    internal class FindAllDuplicates
    {
        static void Main(string[] args)
        {
            int[] arr = { 4, 3, 2, 7, 8, 2, 3, 1 };

            var duplicateNum = FindDuplicates(arr);

            Console.WriteLine(String.Join(',', duplicateNum));
        }

        public static IList<int> FindDuplicates(int[] nums)
        {
            int i = 0;

            var allDuplicates = new List<int>();

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
                if (nums[j] != j + 1)
                {
                    allDuplicates.Add(nums[j]);
                }
            }

            return allDuplicates;
        }

        private static void Swap(int[] arr, int i, int correctIndex)
        {
            int temp = arr[i];
            arr[i] = arr[correctIndex];
            arr[correctIndex] = temp;
        }

    }
}
