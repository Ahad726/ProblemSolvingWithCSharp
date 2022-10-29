using System;
using System.Collections.Generic;
using System.Text;

namespace ProblemSolving.Algo.Searching
{
    internal class QuickSort
    {
        static void Main(string[] args)
        {
            int[] arr1 = { 5, 4, 3, 2, 1 };
            int[] arr = { 6, 3, 7, 5, 2, 8, 12 };
            Sort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(',', arr));

        }

        static void Sort(int[] arr, int low, int high)
        {
            if (low >= high)
            {
                return;
            }

            int s = low;
            int e = high;
            int m = s + (e - s) / 2;
            int pivot = arr[m];
            while (s <= e)
            {
                while (arr[s] <= pivot)
                {
                    s++;
                }

                while (arr[e] > pivot)
                {
                    e--;
                }

                if (s <= e)
                {
                    int temp = arr[s];
                    arr[s] = arr[e];
                    arr[e] = temp;
                    s++;
                    e--;
                } 
            }

            // Now pivot is at correct index, sort the two halves
            Sort(arr, low, e-1);
            Sort(arr,s, high);
        }
    }
}
