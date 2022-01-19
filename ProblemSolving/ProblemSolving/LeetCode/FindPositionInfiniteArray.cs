using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.LeetCode
{
    internal class FindPositionInfiniteArray
    {
        static void Main(string[] args)
        {
            int[] arr = {3, 5, 7, 9, 10, 90, 100, 130,140, 160, 170,180,190,199,200,201,205,206,208,210,220,230,235,245,255};
            Console.WriteLine(FindIndex(arr,100));
        }

        static int FindIndex(int[] arr, int target)
        {
            // first find the range
            // start with box range of size 2
            int start = 0;
            int end = 1;

            // condition for target lie in the range
            while (target > arr[end])
            {
                int newStart = end + 1;

                // double the box size
                end = end + (end - start + 1) * 2;
                start = newStart;
            }

            return BinarySearcher(arr,target,start, end);

        }

        static int BinarySearcher(int[] arr, int target, int start, int end)
        {

            while (start <= end)
            {
                // int arrMid = (start + end) / 2; might be possible that (start+end) exceed the int capacity

                int arrMid = start + (end - start) / 2;
                int mid = arr[arrMid];

                if (mid < target)
                {
                    start = arrMid + 1;
                }
                else if (mid > target)
                {
                    end = arrMid - 1;
                }
                else
                {
                    return arrMid;
                }
            }

            return -1;
        }
    }
}
