using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Sorting
{
    internal class InPlaceMergeSort
    {
        static void Main(string[] args)
        {

            int[] arr1 = { 6, 3, 9, 5, 2, 8 };
            int[] arr2 = { 6, 3, 7, 5, 2, 8,12 };
            int[] arr = { 6, 3, 7 };

            Sort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(',',arr));

        }

        static void Sort(int[] arr, int start, int end)
        {

            if (start >= end)
            {
                return;
            }

            int mid = start + (end - start)/ 2;

            Sort(arr, start, mid);
            Sort(arr, mid + 1, end);

            Merge(arr, start, mid, end);

        }

        private static void Merge(int[] arr, int start, int mid, int end)
        {
            int[] mergedArray = new int[end - start + 1];

            int i = start;
            int j = mid+1;
            int k = 0;

            while (i <= mid && j <= end)
            {
                if (arr[i] <= arr[j])
                {
                    mergedArray[k] = arr[i];
                    i++;
                }
                else
                {
                    mergedArray[k] = arr[j];
                    j++;
                }
                k++;
            }

            while (i <= mid)
            {
                mergedArray[k] = arr[i];
                i++;
                k++;
            }

            while (j <= end)
            {
                mergedArray[k] = arr[j];
                j++;
                k++;
            }

            for (int m = 0, n = start; m < mergedArray.Length; m++, n++)
            {
                arr[n] = mergedArray[m];
            }
        }
    }
}
