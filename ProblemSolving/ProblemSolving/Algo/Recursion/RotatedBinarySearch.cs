using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Recursion
{
    internal class RotatedBinarySearch
    {
        static void Main(string[] args)
        {
            int[] arr = { 5, 6, 7, 8, 9, 1, 2, 3, 4 };

            var index = Search(arr, 8, 0, arr.Length - 1);
            Console.WriteLine(index);

        }

        static int Search(int[] arr, int target, int s, int e)
        {
            int m = s + (e - s) / 2;

            if (s > e)
            {
                return -1;
            }

            if (target == arr[m])
            {
                return m;
            }

           if(arr[s] <= arr[m])
            {
                // array 1st half is sorted. 
                // check if target is here
                if (target >= arr[s] && target <= arr[e])
                {
                    return Search(arr, target, s, m - 1);
                }
                else
                {
                    return Search(arr, target, m + 1, e);
                }
            }

          if (target >= arr[m] && target <= arr[e])
            {
                return Search(arr, target, m + 1, e);
            }
            else
            {
                return Search(arr, target, s, m - 1);

            }
        }
    }
}
