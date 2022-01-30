using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class FindInMountain
    {
        static void Main(string[] args)
        {
            var arr = new int[] {1, 5, 2 };
            int target = 2;

            Console.WriteLine(FindInMountainArray(arr,target));
        }

        static int FindInMountainArray(int[] arr, int target)
        {
            int start = 0;
            int peak = PeakIndexInMontainArray(arr);

            // search in asc part
            int index = BinarySearcher(arr,target,start,peak);

            if (index == -1)
            {
                // search in desc part
                index = BinarySearcher(arr, target, peak, arr.Length - 1);
            }

            return index;


        }

        static int PeakIndexInMontainArray(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                int midIndx = start + (end - start) / 2;
                if (arr[midIndx] < arr[midIndx + 1])
                {
                    // we are in asc part. look right
                    start = midIndx + 1;
                }
                else if (arr[midIndx] > arr[midIndx + 1])
                {
                    // we are in the descending part .
                    // it may be the answer but look at the left
                    end = midIndx;
                }

            }

            return start;
        }

        static int BinarySearcher(int[] arr, int target, int start, int end)
        {

            // find whether the arr is ascending or descending order
            int firstNumber = arr[start];
            int lastNumber = arr[end];

            bool isAsc = firstNumber < lastNumber;


            // ascending order
            while (start <= end)
            {
                // int midIndex = (start + end) / 2; might be possible that (start+end) exceed the int capacity

                int midIndex = start + (end - start) / 2;
                int mid = arr[midIndex];

                if (mid == target)
                {
                    return midIndex;
                }

                if (isAsc)
                {
                    if (mid < target)
                    {
                        start = midIndex + 1;
                    }
                    else
                    {
                        end = midIndex - 1;
                    }
                }

                else
                {
                    if (mid < target)
                    {
                        // search in left
                        end = midIndex - 1;
                    }
                    else
                    {
                        // search right
                        start = midIndex + 1;
                    }
                }
            }
            return -1;
        }
    }
}
