using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class FindMinimum_in_Rotated_Sorted
    {
        static void Main(string[] args)
        {
            int[] arr = { 1 };

            Console.WriteLine(FindMin(arr));
        }

        static int FindMin(int[] arr)
        {
            var peakIndex = FindPeak(arr);

            if(peakIndex == -1 || peakIndex == arr.Length-1)
            {
                return arr[0];
            }
            else
            {
                return arr[peakIndex + 1];
            }
        }

        static int FindPeak(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start)/2;

                if(mid < end && arr[mid] > arr[mid+1] )
                {
                    return mid;
                }
                else if (start < mid && arr[mid] < arr[mid - 1] )
                {
                    return mid - 1;
                }
                else if (arr[start] >= arr[mid])
                {
                    end = mid - 1;
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
