using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Searching
{
    class OrderAgnosticBS
    {
        static void Main(string[] args)
        {
            int[] ascArr = { 2, 3, 5, 7, 10, 11, 14, 20, 36, 40 };

            int[] descArr = { 40, 30, 25, 20, 18, 9, 8, 5 };

            var arr = descArr;
            int target = 18;

            Console.WriteLine(OrderAgnosticBinarySearch(arr, target));

        }

        static int OrderAgnosticBinarySearch(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

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
