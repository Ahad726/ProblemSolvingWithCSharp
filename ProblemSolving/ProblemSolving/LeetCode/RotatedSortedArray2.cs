using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    // https://leetcode.com/problems/search-in-rotated-sorted-array-ii/
    internal class RotatedSortedArray2
    {
        
        static void Main(string[] args)
        {
            int[] arr = { 1};
            int target = 1;

            Console.WriteLine(Search(arr, target));
        }

        static bool Search(int[] num, int target)
        {
            int pivot = FindPivotInDuplicate(num);
            var result = -1;

            if (pivot == -1)
            {
                // do normal binary search
                result = BinarySearch(num, target, 0, num.Length - 1);
            }
            else
            {
                // pivot is found
                if (num[pivot] == target)
                {
                    result = pivot;
                }
                else if (target >= num[0])
                {
                    result = BinarySearch(num, target, 0, pivot);
                }
                else
                {
                    result = BinarySearch(num, target, pivot + 1, num.Length - 1);
                }
            }

            bool rslt = result == -1 ? false : true;

            return rslt;


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

        static int FindPivotInDuplicate(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int mid = start + (end - start) / 2;

                if (mid < end && arr[mid] > arr[mid + 1])
                {
                    return mid;
                }
                else if (mid > start && arr[mid - 1] > arr[mid])
                {
                    return mid - 1;
                }

                // if elements at start, mid and end are equal then skip the duplicates
                else if (arr[start] == arr[mid] && arr[mid] == arr[end])
                {
                    // what if these element at start and end were pivot?
                    
                    // check if start is pivot
                    if (arr[start] > arr[start+1])
                    {
                        return start;
                    }
                    start++;

                    // check if end is pivot
                    if (arr[end - 1] > arr[end])
                    {
                        return end - 1;
                    }
                    end--;
                }

                // left side is sorted. so pivot should be in right
                else if(arr[start] < arr[mid] || arr[start] == arr[mid] && arr[mid] > arr[end])
                {
                    start = mid + 1;
                }
                else
                {
                    end = mid - 1;
                }
                
            }

            return -1;
        }
    }
}
