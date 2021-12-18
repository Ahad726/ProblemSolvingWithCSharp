using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    class Ceiling_sorted_array
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 3, 5, 9, 14,15, 16, 18 };
            int target = 25;

            int result = CeilingFinder(arr, target);
            Console.WriteLine(result);
        }
        static int CeilingFinder(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;
            if (arr[end] < target)
            {
                // Ceiling doesn't exist
                return -1;
            }
            while (start <= end)
            {
                int midIndex = start + (end - start) / 2;
                int mid = arr[midIndex];

                if (target < mid)
                {
                    end = midIndex - 1;
                }
                else if(target > mid)
                {
                    start = midIndex + 1;
                }
                else
                {
                    return mid;
                }
            }

            return arr[start];

        }
    }
}
