using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    //  https://leetcode.com/problems/search-in-rotated-sorted-array/
    internal class RotatedSortedArray
    {
        static void Main(string[] args)
        {
            int[] arr = { 1 };
            int target = 1;

            Console.WriteLine(Search(arr,target));

        }

        static int Search(int[] num, int target)
        {

            int pivot = FindPivot(num);

            if (pivot == -1)
            {
                // do normal binary search
                return BinarySearch(num, target, 0, num.Length - 1);
            }
            else{
                // pivot is found
                if(num[pivot] == target)
                {
                    return pivot;
                }
                else if (target >= num[0])
                {
                    return BinarySearch(num, target,0, pivot);
                }
                else
                {
                    return BinarySearch(num, target, pivot + 1, num.Length - 1);
                }
            }

        }

        static int BinarySearch(int[] arr, int target, int start, int end)
        {

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr[mid] > target)
                {
                    end = mid - 1;
                }
                else if (arr[mid] < target)
                {
                    start = mid + 1;
                }
                else
                {
                    return mid;
                }
            }

            return -1;
        }


        static int FindPivot(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while(start <= end)
            {
                int mid = start + (end - start) / 2;

                if (mid < end && arr[mid] > arr[mid + 1])
                {
                    return mid;
                }
                if (mid > start && arr[mid - 1] > arr[mid])
                {
                    return mid-1;
                }
                if (arr[start] >= arr[mid])
                {
                    end =mid-1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            return -1;
        }
    }
}
