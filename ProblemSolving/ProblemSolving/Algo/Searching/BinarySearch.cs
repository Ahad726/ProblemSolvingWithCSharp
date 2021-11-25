using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Searching
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr =  { 2, 3, 5, 7, 10, 11, 14, 20, 36, 40 };
            int target = 5;
            Console.WriteLine(BinarySearcher(arr,target));
        }

        // return the index 
        // return -1 if it does not exist
        static int BinarySearcher(int[] arr, int target)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start <= end)
            {
                // int arrMid = (start + end) / 2; might be possible that (start+end) exceed the int capacity

                int arrMid = start + (end-start) / 2;
                int mid = arr[arrMid];

                if(mid < target)
                {
                    start = arrMid + 1;
                }
                else if(mid > target)
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
