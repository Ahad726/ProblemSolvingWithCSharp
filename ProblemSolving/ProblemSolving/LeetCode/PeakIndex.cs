using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class PeakIndex
    {
        static void Main(string[] args)
        {
            var arr = new[] { 0, 1, 2, 5, 7, 9, 6, 2, 1, 0 };
            Console.WriteLine(PeakIndexInMontainArray(arr));
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
    }
}
